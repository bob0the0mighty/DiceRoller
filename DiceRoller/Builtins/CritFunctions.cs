﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dice.AST;

namespace Dice.Builtins
{
    /// <summary>
    /// Builtin functions that deal with marking dice as criticals or fumbles.
    /// </summary>
    public static class CritFunctions
    {
        /// <summary>
        /// Marks dice as critical successes if the comparison succeeds against them.
        /// Will also strip pre-existing critical markings from dice.
        /// </summary>
        /// <param name="context">Function context.</param>
        [DiceFunction("critical", "cs",
            ArgumentPattern = "C+",
            Behavior = FunctionBehavior.CombineArguments,
            Scope = FunctionScope.Roll,
            Timing = FunctionTiming.Crit)]
        public static void Critical(FunctionContext context)
        {
            MarkCrits(context ?? throw new ArgumentNullException(nameof(context)),
                critical: new ComparisonNode(context.Arguments.Cast<ComparisonNode>()));
        }

        /// <summary>
        /// Marks dice as fumbles if the comparison succeeds against them.
        /// Will also strip pre-existing fumble markings from dice.
        /// </summary>
        /// <param name="context">Function context.</param>
        [DiceFunction("fumble", "cf",
            ArgumentPattern = "C+",
            Behavior = FunctionBehavior.CombineArguments,
            Scope = FunctionScope.Roll,
            Timing = FunctionTiming.Crit)]
        public static void Fumble(FunctionContext context)
        {
            MarkCrits(context ?? throw new ArgumentNullException(nameof(context)),
                fumble: new ComparisonNode(context.Arguments.Cast<ComparisonNode>()));
        }

        private static void MarkCrits(FunctionContext context, ComparisonNode? critical = null, ComparisonNode? fumble = null)
        {
            var values = new List<DieResult>();
            DieFlags mask = 0;
            context.Value = context.Expression!.Value;
            context.ValueType = context.Expression.ValueType;

            if (critical != null)
            {
                mask |= DieFlags.Critical;
            }

            if (fumble != null)
            {
                mask |= DieFlags.Fumble;
            }

            foreach (var die in context.Expression.Values)
            {
                DieFlags flags = 0;

                if (die.DieType == DieType.Special || die.DieType == DieType.Group)
                {
                    // we don't skip over dropped dice here since we DO still want to
                    // mark them as criticals/fumbles as needed.
                    values.Add(die);
                    continue;
                }

                if (critical?.Compare(die.Value) == true)
                {
                    flags |= DieFlags.Critical;

                    if (context.ValueType == ResultType.Successes)
                    {
                        // just in case the die wasn't already marked as a success
                        flags |= DieFlags.Success;
                    }
                }

                if (fumble?.Compare(die.Value) == true)
                {
                    flags |= DieFlags.Fumble;

                    if (context.ValueType == ResultType.Successes)
                    {
                        // just in case the die wasn't already marked as a failure
                        flags |= DieFlags.Failure;
                    }
                }

                var newDie = new DieResult()
                {
                    DieType = die.DieType,
                    NumSides = die.NumSides,
                    Value = die.Value,
                    // strip any existing crit/fumble flag off and use ours,
                    // assuming a comparison was defined for it.
                    // (we may have an existing flag if the die rolled min or max value)
                    Flags = (die.Flags & ~mask) | flags
                };

                // if tracking successes, a critical success is worth 2 successes and a critical failure (fumble + failure) is worth 2 failures
                // adjust our value to the difference between our new success count and prior one if any
                if (context.ValueType == ResultType.Successes)
                {
                    context.Value += newDie.SuccessCount - die.SuccessCount;
                }

                values.Add(newDie);
            }

            context.Values = values;
        }
    }
}
