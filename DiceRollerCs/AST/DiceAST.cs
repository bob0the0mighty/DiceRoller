﻿using System;
using System.Text;
using System.Collections.Generic;


namespace Dice.AST
{
    /// <summary>
    /// Represents a node in the dice expression Abstract Syntax Tree
    /// </summary>
    public abstract class DiceAST
    {
        /// <summary>
        /// If true, this node has been evaluated
        /// </summary>
        public bool Evaluated { get; private set; }

        /// <summary>
        /// The final value of this node.
        /// </summary>
        public decimal Value { get; protected set; }

        /// <summary>
        /// What type of value we have (total or successes).
        /// </summary>
        public ResultType ValueType { get; protected set; } = ResultType.Total;

        /// <summary>
        /// Gets the roll node underneath this node, unless this node is a roll node of some sort.
        /// Nodes that can branch (such as MathNode) may be returned as well.
        /// </summary>
        protected internal virtual DiceAST UnderlyingRollNode => this;

        /// <summary>
        /// The underlying dice that were rolled, as well as their values.
        /// If no dice were rolled, this will be an empty list.
        /// </summary>
        public abstract IReadOnlyList<DieResult> Values { get; }

        /// <summary>
        /// Retrieves a normalized representation of the dice expression.
        /// This may differ from the exact string that was typed in by the user.
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        /// <summary>
        /// Evaluates the node, causing it to store its result in Value.
        /// </summary>
        /// <param name="conf">Configuration of the roller</param>
        /// <param name="root">Root of the AST</param>
        /// <param name="depth">Current recursion depth</param>
        /// <returns>Total number of rolls taken to evaluate this subtree</returns>
        protected internal long Evaluate(RollerConfig conf, DiceAST root, int depth)
        {
            if (this == root)
            {
                conf.InternalContext = new InternalContext();
            }

            if (depth > conf.MaxRecursionDepth)
            {
                throw new DiceException(DiceErrorCode.RecursionDepthExceeded, conf.MaxRecursionDepth);
            }

            long rolls = EvaluateInternal(conf, root, depth);

            if (rolls > conf.MaxDice)
            {
                throw new DiceException(DiceErrorCode.TooManyDice, conf.MaxDice);
            }

            Evaluated = true;

            return rolls;
        }

        /// <summary>
        /// Re-do the roll without re-evaluating the entire subtree again
        /// </summary>
        /// <param name="conf">Roller config</param>
        /// <param name="root">AST root</param>
        /// <param name="depth">Recursion depth</param>
        /// <returns>Number of dice rolls performed</returns>
        protected internal long Reroll(RollerConfig conf, DiceAST root, int depth)
        {
            if (!Evaluated)
            {
                return Evaluate(conf, root, depth);
            }

            if (depth > conf.MaxRecursionDepth)
            {
                throw new DiceException(DiceErrorCode.RecursionDepthExceeded, conf.MaxRecursionDepth);
            }

            long rolls = RerollInternal(conf, root, depth);

            if (rolls > conf.MaxDice)
            {
                throw new DiceException(DiceErrorCode.TooManyDice, conf.MaxDice);
            }

            return rolls;
        }

        protected abstract long EvaluateInternal(RollerConfig conf, DiceAST root, int depth);
        protected abstract long RerollInternal(RollerConfig conf, DiceAST root, int depth);
    }
}
