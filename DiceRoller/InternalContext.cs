﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dice.AST;

namespace Dice
{
    internal class InternalContext
    {
        internal List<uint> AllRolls = new List<uint>();
        internal List<decimal> AllMacros = new List<decimal>();
        internal List<RollNode> RollExpressions = new List<RollNode>();
        internal List<ValueSnapshot> RollValues = new List<ValueSnapshot>();
        internal List<DiceAST> GroupExpressions = new List<DiceAST>();
        internal List<ValueSnapshot> GroupValues = new List<ValueSnapshot>();

        internal void AddRollExpression(RollNode roll)
        {
            RollExpressions.Add(roll);
            RollValues.Add(new ValueSnapshot(roll));
        }

        internal string AddGroupExpression(DiceAST expr)
        {
            GroupExpressions.Add(expr);
            GroupValues.Add(new ValueSnapshot(expr));
            return (GroupExpressions.Count - 1).ToString(CultureInfo.InvariantCulture);
        }

        internal DiceAST GetGroupExpression(string key)
        {
            return GroupExpressions[Convert.ToInt32(key, CultureInfo.InvariantCulture)];
        }

        internal ValueSnapshot GetGroupValues(string key)
        {
            return GroupValues[Convert.ToInt32(key, CultureInfo.InvariantCulture)];
        }

        internal class ValueSnapshot
        {
            internal decimal Value;
            internal List<DieResult> Values;
            internal ValueType ValueType;

            internal ValueSnapshot(DiceAST expr)
            {
                Value = expr.Value;
                Values = expr.Values.ToList();
                ValueType = expr.ValueType;
            }
        }
    }
}
