﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Dice.AST
{
    /// <summary>
    /// Holds information about a comparison, which checks a CompareOp against an expression.
    /// </summary>
    public struct Comparison : IEquatable<Comparison>
    {

        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields",
            Justification = "No need for overhead of property, given this is typically only used internally.")]
        public CompareOp op;
        [SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields",
            Justification = "No need for overhead of property, given this is typically only used internally.")]
        public DiceAST expr;

        public Comparison(CompareOp op, DiceAST expr)
        {
            this.op = op;
            this.expr = expr;
        }

        public override bool Equals(object obj)
        {
            if (obj is Comparison c)
            {
                return Equals(c);
            }

            return false;
        }

        public bool Equals(Comparison other)
        {
            return op == other.op && expr == other.expr;
        }

        public override int GetHashCode()
        {
            return new { op, expr }.GetHashCode();
        }

        public static bool operator==(Comparison a, Comparison b)
        {
            return a.Equals(b);
        }

        public static bool operator!=(Comparison a, Comparison b)
        {
            return !a.Equals(b);
        }
    }
}
