﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.AST
{
    /// <summary>
    /// Represents a function call, either a global function
    /// or one attached to a roll.
    /// </summary>
    public class FunctionNode : DiceAST
    {
        /// <summary>
        /// The context for this function call
        /// </summary>
        public FunctionContext Context { get; private set; }

        internal FunctionTiming Timing;
        private FunctionCallback Function;

        public override IReadOnlyList<DieResult> Values
        {
            get { return Context.Values ?? Context.Expression?.Values ?? new List<DieResult>(); }
        }

        internal FunctionNode(FunctionScope scope, string name, IReadOnlyList<DiceAST> arguments)
        {
            Context = new FunctionContext(scope, name, arguments);

            try
            {
                (Timing, Function) = FunctionRegistry.Callbacks[(name, scope)];
            }
            catch (KeyNotFoundException)
            {
                throw new DiceException(DiceErrorCode.NoSuchFunction, name);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Context.Scope != FunctionScope.Global)
            {
                sb.Append(".");
            }

            sb.Append(Context.Name);
            sb.Append("(");
            sb.Append(String.Join(", ", Context.Arguments.Select(o => o.ToString())));
            sb.Append(")");

            return sb.ToString();
        }

        protected override ulong EvaluateInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            ulong rolls = Context.Expression?.Evaluate(conf, root, depth + 1) ?? 0;

            foreach (var arg in Context.Arguments)
            {
                rolls += arg.Evaluate(conf, root, depth + 1);
            }

            CallFunction();

            return rolls;
        }

        protected override ulong RerollInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            ulong rolls = Context.Expression?.Reroll(conf, root, depth + 1) ?? 0;

            foreach (var arg in Context.Arguments)
            {
                rolls += arg.Reroll(conf, root, depth + 1);
            }

            CallFunction();

            return rolls;
        }

        private void CallFunction()
        {
            Function(Context);
            Value = Context.Value;

            if (Context.Value == Decimal.MinValue)
            {
                throw new InvalidOperationException("Function callback did not modify context.Value");
            }
        }
    }
}
