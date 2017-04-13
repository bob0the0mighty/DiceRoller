﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Dice.AST
{
    /// <summary>
    /// Represents dice that reroll when certain conditions are met
    /// </summary>
    public class ExplodeNode : DiceAST
    {
        private List<DieResult> _values;

        /// <summary>
        /// What type of exploding dice we have
        /// </summary>
        public ExplodeType ExplodeType { get; private set; }

        /// <summary>
        /// If true, exploding die results are combined into a single DieResult.
        /// If false, each exploding die is its own DieResult.
        /// </summary>
        public bool Compound { get; private set; }

        /// <summary>
        /// The expression to compare against to determine whether or not to explode.
        /// If null, dice explode when they roll their maximum result.
        /// </summary>
        public ComparisonNode Comparison { get; private set; }

        /// <summary>
        /// The dice being rolled.
        /// </summary>
        public DiceAST Expression { get; internal set; }

        public override IReadOnlyList<DieResult> Values
        {
            get { return _values; }
        }

        internal ExplodeNode(ExplodeType explodeType, bool compound, ComparisonNode comparison)
        {
            ExplodeType = explodeType;
            Compound = compound;
            Comparison = comparison;
            Expression = null;
            _values = new List<DieResult>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Expression?.ToString() ?? String.Empty);

            switch (ExplodeType)
            {
                case ExplodeType.Explode:
                    if (Compound)
                    {
                        sb.Append(".compound");
                    }
                    else
                    {
                        sb.Append(".explode");
                    }
                    break;
                case ExplodeType.Penetrate:
                    if (Compound)
                    {
                        sb.Append(".compoundPenetrate");
                    }
                    else
                    {
                        sb.Append(".penetrate");
                    }
                    break;
            }

            sb.AppendFormat("({0})", Comparison?.ToString() ?? String.Empty);

            return sb.ToString();
        }

        internal void AddComparison(ComparisonNode comp)
        {
            if (Comparison == null)
            {
                throw new DiceException(DiceErrorCode.MixedExplodeComp);
            }

            Comparison.Add(comp ?? throw new ArgumentNullException("comp"));
        }

        protected override long EvaluateInternal(RollerConfig conf, DiceAST root, int depth)
        {
            long rolls = Comparison?.Evaluate(conf, root, depth + 1) ?? 0;
            rolls += Expression.Evaluate(conf, root, depth + 1);
            rolls += DoExplode(conf);

            return rolls;
        }

        protected override long RerollInternal(RollerConfig conf, DiceAST root, int depth)
        {
            long rolls = 0;
            if (Comparison?.Evaluated == false)
            {
                rolls += Comparison.Evaluate(conf, root, depth + 1);
            }

            rolls += Expression.Reroll(conf, root, depth + 1);
            rolls += DoExplode(conf);

            return rolls;
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "Cannot be easily refactored.")]
        private long DoExplode(RollerConfig conf)
        {
            long rolls = 0;
            Func<DieResult, bool> shouldExplode, shouldExplode2;
            Value = 0;
            ValueType = ResultType.Total;
            _values.Clear();

            if (Comparison != null)
            {
                shouldExplode = d => Comparison.Compare(d.Value);

                if (ExplodeType == ExplodeType.Penetrate)
                {
                    shouldExplode2 = d => Comparison.Compare(d.Value + 1);
                }
                else
                {
                    shouldExplode2 = shouldExplode;
                }
            }
            else
            {
                shouldExplode = d => d.Value == d.NumSides;

                if (ExplodeType == ExplodeType.Penetrate)
                {
                    shouldExplode2 = d => d.Value + 1 == d.NumSides;
                }
                else
                {
                    shouldExplode2 = shouldExplode;
                }
            }


            foreach (var die in Expression.Values)
            {
                var accum = die;

                if (die.DieType == DieType.Special || die.Flags.HasFlag(DieFlags.Dropped))
                {
                    // special die results can't explode as they aren't actually dice
                    // dropped dice are no longer part of the resultant expression so should not explode
                    _values.Add(die);

                    continue;
                }

                RollType rt;
                switch (die.DieType)
                {
                    case DieType.Normal:
                        rt = RollType.Normal;
                        break;
                    case DieType.Fudge:
                        rt = RollType.Fudge;
                        break;
                    case DieType.Group: // we can't explode on groups, so throw an exception
                    default:
                        throw new InvalidOperationException("Unsupported die type for explosion");
                }

                Value += die.Value;
                if (shouldExplode(die))
                {
                    if (!Compound)
                    {
                        _values.Add(die);
                    }

                    DieResult result;

                    do
                    {
                        rolls++;

                        if (rolls > conf.MaxDice)
                        {
                            throw new DiceException(DiceErrorCode.TooManyDice, conf.MaxDice);
                        }

                        if (rolls > conf.MaxRerolls)
                        {
                            break;
                        }

                        var numSides = die.NumSides;
                        if (ExplodeType == ExplodeType.Penetrate && Comparison == null)
                        {
                            // if penetrating dice are used, d100p penetrates to d20p,
                            // and d20p penetrates to d6p (however, the d20p from
                            // the d100p does not further drop to d6p).
                            // only do this if a custom comparison expression was not used.
                            if (numSides == 100)
                            {
                                numSides = 20;
                            }
                            else if (numSides == 20)
                            {
                                numSides = 6;
                            }
                        }

                        result = RollNode.DoRoll(conf, rt, numSides, DieFlags.Extra);
                        switch (ExplodeType)
                        {
                            case ExplodeType.Explode:
                                break;
                            case ExplodeType.Penetrate:
                                result.Value -= 1;
                                break;
                            default:
                                throw new InvalidOperationException("Unknown explosion type");
                        }

                        Value += result.Value;
                        if (Compound)
                        {
                            accum.Value += result.Value;
                        }
                        else
                        {
                            _values.Add(new DieResult()
                            {
                                DieType = DieType.Special,
                                NumSides = 0,
                                Value = (decimal)SpecialDie.Add,
                                Flags = 0
                            });
                            _values.Add(result);
                        }
                    } while (shouldExplode2(result));

                    if (Compound)
                    {
                        _values.Add(accum);
                    }
                }
                else
                {
                    _values.Add(die);
                }
            }

            return rolls;
        }
    }
}
