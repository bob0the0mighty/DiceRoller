﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.AST
{
    /// <summary>
    /// Represents a roll where we count the number of successes and failures
    /// in a dice pool rather than accumulating the die rolls. The Value of
    /// this node is the number of Successes minus the number of Failures.
    /// </summary>
    public class SuccessNode : DiceAST
    {
        private List<DieResult> _values;

        /// <summary>
        /// What should be viewed as a success.
        /// </summary>
        public ComparisonNode Success { get; private set; }

        /// <summary>
        /// What should be viewed as a failure, may be null.
        /// Failures deduct 1 success, so that negative successes may be possible.
        /// If null, failures are not possible.
        /// </summary>
        public ComparisonNode Failure { get; private set; }

        /// <summary>
        /// Underlying roll expression.
        /// </summary>
        public DiceAST Expression { get; internal set; }

        /// <summary>
        /// Number of successes, only valid if Evaluated is true.
        /// </summary>
        public uint Successes { get; private set; }

        /// <summary>
        /// Number of failures, only valid if Evaluated is true.
        /// </summary>
        public uint Failures { get; private set; }

        public override IReadOnlyList<DieResult> Values
        {
            get { return _values; }
        }

        internal SuccessNode(ComparisonNode success, ComparisonNode failure)
        {
            Expression = null;
            Success = success;
            Failure = failure;
            if (success == null && failure == null)
            {
                throw new ArgumentException("success and failure cannot both be null");
            }
            _values = new List<DieResult>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(".success({0})", Success.ToString());

            if (Failure != null)
            {
                sb.AppendFormat(".failure({0})", Failure.ToString());
            }

            return sb.ToString();
        }

        internal void AddSuccess(ComparisonNode comp)
        {
            if (comp == null)
            {
                throw new ArgumentNullException("comp");
            }

            if (Success == null)
            {
                Success = comp;
            }
            else
            {
                Success.Add(comp);
            }
        }

        internal void AddFailure(ComparisonNode comp)
        {
            if (comp == null)
            {
                throw new ArgumentNullException("comp");
            }

            if (Failure == null)
            {
                Failure = comp;
            }
            else
            {
                Failure.Add(comp);
            }
        }

        protected override ulong EvaluateInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            ulong rolls = Expression.Evaluate(conf, root, depth + 1);
            rolls += Success.Evaluate(conf, root, depth + 1);
            rolls += Failure?.Evaluate(conf, root, depth + 1) ?? 0;

            CountSuccesses();

            return rolls;
        }

        protected override ulong RerollInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            ulong rolls = Expression.Reroll(conf, root, depth + 1);

            if (!Success.Evaluated)
            {
                rolls += Success.Evaluate(conf, root, depth + 1);
            }

            if (Failure?.Evaluated == false)
            {
                rolls += Failure.Evaluate(conf, root, depth + 1);
            }

            CountSuccesses();

            return rolls;
        }

        private void CountSuccesses()
        {
            Successes = 0;
            Failures = 0;
            _values.Clear();

            foreach (var die in Values)
            {
                if (die.DieType == DieType.Special || die.Flags.HasFlag(DieFlags.Dropped))
                {
                    _values.Add(die);
                    continue;
                }

                if (Success.Compare(die.Value))
                {
                    Successes++;
                    _values.Add(new DieResult()
                    {
                        DieType = die.DieType,
                        NumSides = die.NumSides,
                        Value = die.Value,
                        Flags = die.Flags | DieFlags.Success
                    });
                }
                else if (Failure?.Compare(die.Value) == true)
                {
                    Failures++;
                    _values.Add(new DieResult()
                    {
                        DieType = die.DieType,
                        NumSides = die.NumSides,
                        Value = die.Value,
                        Flags = die.Flags | DieFlags.Failure
                    });
                }
                else
                {
                    _values.Add(die);
                }
            }

            Value = Successes - Failures;
        }
    }
}
