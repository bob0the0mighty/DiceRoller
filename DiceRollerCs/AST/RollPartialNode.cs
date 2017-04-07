﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.AST
{
    /// <summary>
    /// An ephemeral node used in construction of the AST. Once the AST
    /// is fully constructed, no nodes of this type should exist in it.
    /// </summary>
    public class RollPartialNode : DiceAST
    {
        public RollNode Roll { get; internal set; }
        public List<KeepNode> Keep { get; private set; }
        public SortNode Sort { get; private set; }
        public RerollNode RerollNode { get; private set; }
        public ExplodeNode Explode { get; private set; }
        public CritNode Critical { get; private set; }
        public SuccessNode Success { get; private set; }
        public List<FunctionNode> Functions { get; private set; }

        private bool haveAdvantage = false;

        public override IReadOnlyList<DieResult> Values => throw new InvalidOperationException("This node should not exist in an AST");

        internal RollPartialNode(RollNode roll)
        {
            Roll = roll ?? throw new ArgumentNullException("roll");
            Keep = new List<KeepNode>();
            Sort = null;
            RerollNode = null;
            Explode = null;
            Critical = null;
            Success = null;
            Functions = new List<FunctionNode>();
        }

        internal void AddKeep(KeepNode keep)
        {
            if (keep.KeepType == KeepType.Advantage || keep.KeepType == KeepType.Disadvantage)
            {
                if (Keep.Count > 0)
                {
                    throw new DiceException(DiceErrorCode.NoAdvantageKeep);
                }

                haveAdvantage = true;
            }
            else if (haveAdvantage)
            {
                throw new DiceException(DiceErrorCode.NoAdvantageKeep);
            }

            Keep.Add(keep ?? throw new ArgumentNullException("keep"));
        }

        internal void AddSort(SortNode sort)
        {
            if (Sort != null)
            {
                throw new DiceException(DiceErrorCode.TooManySort);
            }

            Sort = sort ?? throw new ArgumentNullException("sort");
        }

        internal void AddReroll(RerollNode reroll)
        {
            if (reroll == null)
            {
                throw new ArgumentNullException("reroll");
            }

            if (RerollNode != null && RerollNode.MaxRerolls != reroll.MaxRerolls)
            {
                throw new DiceException(DiceErrorCode.MixedReroll);
            }

            if (RerollNode == null)
            {
                RerollNode = reroll;
            }
            else
            {
                RerollNode.Comparison.Add(reroll.Comparison);
            }
        }

        internal void AddExplode(ExplodeNode explode)
        {
            if (explode == null)
            {
                throw new ArgumentNullException("explode");
            }

            if (Explode != null && (Explode.ExplodeType != explode.ExplodeType || Explode.Compound != explode.Compound))
            {
                throw new DiceException(DiceErrorCode.MixedExplode);
            }

            if (Explode == null)
            {
                Explode = explode;
            }
            else
            {
                Explode.Comparison.Add(explode.Comparison);
            }
        }

        internal void AddCritical(CritNode crit)
        {
            if (crit == null)
            {
                throw new ArgumentNullException("crit");
            }

            if (Critical == null)
            {
                Critical = crit;
                return;
            }
            else
            {
                Critical.AddCritical(crit.Critical);
                Critical.AddFumble(crit.Fumble);
            }
        }

        internal void AddSuccess(SuccessNode success)
        {
            if (success == null)
            {
                throw new ArgumentNullException("success");
            }

            if (Success == null)
            {
                Success = success;
                return;
            }
            else
            {
                Success.AddSuccess(success.Success);
                Success.AddFailure(success.Failure);
            }
        }

        internal void AddFunction(FunctionNode fn)
        {
            Functions.Add(fn ?? throw new ArgumentNullException("fn"));
        }

        /// <summary>
        /// Creates the RollNode subtree
        /// </summary>
        /// <returns></returns>
        internal DiceAST CreateGroupNode()
        {
            DiceAST roll = Roll;
            AddFunctionNodes(FunctionTiming.First, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeExplode, ref roll);
            if (Explode != null)
            {
                Explode.Expression = roll;
                roll = Explode;
            }
            AddFunctionNodes(FunctionTiming.AfterExplode, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeReroll, ref roll);
            if (RerollNode != null)
            {
                RerollNode.Expression = roll;
                roll = RerollNode;
            }
            AddFunctionNodes(FunctionTiming.AfterReroll, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeKeep, ref roll);
            foreach (var k in Keep)
            {
                k.Expression = roll;
                roll = k;
            }
            AddFunctionNodes(FunctionTiming.AfterKeep, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeSuccess, ref roll);
            if (Success != null)
            {
                if (Success.Success.Comparisons.Count() == 0 && Success.Failure.Comparisons.Count() > 0)
                {
                    throw new DiceException(DiceErrorCode.InvalidSuccess);
                }

                Success.Expression = roll;
                roll = Success;
            }
            AddFunctionNodes(FunctionTiming.AfterSuccess, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeCrit, ref roll);
            if (Critical != null)
            {
                Critical.Expression = roll;
                roll = Critical;
            }
            AddFunctionNodes(FunctionTiming.AfterCrit, ref roll);
            AddFunctionNodes(FunctionTiming.BeforeSort, ref roll);
            if (Sort != null)
            {
                Sort.Expression = roll;
                roll = Sort;
            }
            AddFunctionNodes(FunctionTiming.AfterSort, ref roll);
            AddFunctionNodes(FunctionTiming.Last, ref roll);

            return roll;
        }

        private void AddFunctionNodes(FunctionTiming timing, ref DiceAST node)
        {
            foreach (var fn in Functions.Where(f => f.Timing == timing))
            {
                fn.Context.Expression = node;
                node = fn;
            }
        }

        protected override ulong EvaluateInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            throw new InvalidOperationException("This node should not exist in an AST");
        }

        protected override ulong RerollInternal(RollerConfig conf, DiceAST root, uint depth)
        {
            throw new InvalidOperationException("This node should not exist in an AST");
        }
    }
}
