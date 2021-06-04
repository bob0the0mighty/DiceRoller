﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.AST
{
    /// <summary>
    /// An ephemeral node used in construction of the AST. Once the AST
    /// is fully constructed, no nodes of this type should exist in it.
    /// </summary>
    internal class GroupPartialNode : PartialNode
    {
        /// <summary>
        /// Number of times the group will be evaluated.
        /// </summary>
        public DiceAST? NumTimes { get; internal set; }

        /// <summary>
        /// Expressions comprising the grouped roll.
        /// </summary>
        public List<DiceAST> GroupExpressions { get; private set; }

        /// <inheritdoc/>
        protected override FunctionScope FunctionScope => FunctionScope.Group;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPartialNode"/> class.
        /// </summary>
        internal GroupPartialNode()
        {
            GroupExpressions = new List<DiceAST>();
            Functions = new List<FunctionNode>();
            NumTimes = null;
        }

        /// <summary>
        /// Add an expression to the grouped roll.
        /// </summary>
        /// <param name="expression">Expression to add.</param>
        internal void AddExpression(DiceAST expression)
        {
            GroupExpressions.Add(expression);
        }

        /// <summary>
        /// Creates the GroupNode from all of the partial pieces and returns the root of the GroupNode's subtree.
        /// </summary>
        /// <param name="numTimes">Expression to roll the group some number of times, may be null.</param>
        /// <returns>Returns the created GroupNode.</returns>
        internal DiceAST CreateGroupNode()
        {
            DiceAST group = new GroupNode(NumTimes, GroupExpressions);

            foreach (FunctionTiming timing in Enum.GetValues(typeof(FunctionTiming)))
            {
                AddFunctionNodes(timing, ref group);
            }

            return group;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("GPARTIAL<<");
            if (NumTimes != null)
            {
                if (NumTimes is LiteralNode || NumTimes is MacroNode)
                {
                    sb.Append(NumTimes.ToString());
                }
                else
                {
                    sb.AppendFormat(CultureInfo.InvariantCulture, "({0})", NumTimes.ToString());
                }
            }

            sb.Append('{');
            sb.Append(String.Join(", ", GroupExpressions.Select(o => o.ToString())));
            sb.Append('}');

            foreach (FunctionTiming timing in Enum.GetValues(typeof(FunctionTiming)))
            {
                foreach (var fn in Functions.Where(f => f.Slot.Timing == timing))
                {
                    sb.Append(fn.ToString());
                }
            }

            sb.Append(">>");

            return sb.ToString();
        }
    }
}
