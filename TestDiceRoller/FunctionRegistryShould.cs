﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Dice;

namespace TestDiceRoller
{
    [TestClass]
    public class FunctionRegistryShould : TestBase
    {
        [TestMethod]
        public void Successfully_RegisterStaticFunctions()
        {
            var registry = new FunctionRegistry();
            registry.RegisterType(typeof(FunctionContainer));
            var conf = new RollerConfig() { FunctionRegistry = registry, GetRandomBytes = GetRNG(Roll9()) };
            EvaluateRoll("1d20.a()", conf, 1, "1d20.a() => 9 => 10");
        }

        [TestMethod]
        public void Successfully_RegisterAllFunctions()
        {
            var registry = new FunctionRegistry();
            var cont = new FunctionContainer(2);
            registry.RegisterType(cont);
            Assert.IsTrue(registry.Contains("a", FunctionScope.Basic));
            Assert.IsTrue(registry.Contains("b", FunctionScope.Global));
            Assert.IsFalse(registry.Contains("c", FunctionScope.Global));

            var conf = new RollerConfig() { FunctionRegistry = registry, GetRandomBytes = GetRNG(Roll9()) };
            EvaluateRoll("1d20.a()", conf, 1, "1d20.a() => 9 => 10");
            EvaluateRoll("1d20.b()", conf, 1, "1d20.b() => 9 => 11");
            EvaluateRoll("b()", conf, 0, "b() => 2 => 2");
        }

        [TestMethod]
        public void Successfully_RegisterFunction()
        {
            var registry = new FunctionRegistry();
            registry.RegisterFunction("c", FunctionContainer.A, FunctionScope.Basic);
            var conf = new RollerConfig() { FunctionRegistry = registry, GetRandomBytes = GetRNG(Roll9()) };
            EvaluateRoll("1d20.c()", conf, 1, "1d20.c() => 9 => 10");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenDuplicatingFunctionWithAll_Function()
        {
            var registry = new FunctionRegistry();
            registry.RegisterFunction("c", FunctionContainer.A, FunctionScope.Basic);
            registry.RegisterFunction("c", FunctionContainer.A, FunctionScope.All);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenDuplicatingFunctionWithAll_Type()
        {
            var registry = new FunctionRegistry();
            registry.RegisterType(typeof(Invalid2));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenInvalidDiceFunctionAttribute()
        {
            new FunctionRegistry().RegisterType(typeof(Invalid1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullException_WhenRemovingNullFunction()
        {
            var registry = new FunctionRegistry();
            registry.Remove(null, FunctionScope.All);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentException_WhenRemovingBuiltinFunction()
        {
            var registry = new FunctionRegistry();
            registry.Remove("reroll", FunctionScope.Basic);
        }

        [TestMethod]
        public void Successfully_RemoveFunction()
        {
            var registry = new FunctionRegistry();
            registry.RegisterFunction("a", Invalid2.A, FunctionScope.All);

            Assert.IsTrue(registry.Contains("a", FunctionScope.Basic));
            Assert.IsTrue(registry.Contains("a", FunctionScope.Group));
            Assert.IsTrue(registry.Contains("a", FunctionScope.Global));

            registry.Remove("a", FunctionScope.Basic);

            Assert.IsFalse(registry.Contains("a", FunctionScope.Basic));
            Assert.IsTrue(registry.Contains("a", FunctionScope.Group));
            Assert.IsTrue(registry.Contains("a", FunctionScope.Global));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentException_WhenRemoveAll()
        {
            var registry = new FunctionRegistry();
            registry.RegisterFunction("a", Invalid2.A, FunctionScope.All);
            registry.Remove("a", FunctionScope.All);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowArgumentException_WhenRemoveRoll()
        {
            var registry = new FunctionRegistry();
            registry.RegisterFunction("a", Invalid2.A, FunctionScope.All);
            registry.Remove("a", FunctionScope.Roll);
        }

        private class FunctionContainer
        {
            [DiceFunction("a", Scope = FunctionScope.Roll, Timing = FunctionTiming.First)]
            public static void A(FunctionContext context)
            {
                // adds one to the die
                context.Value = context.Expression.Value + 1;
            }

            private int b;

            public FunctionContainer(int amt)
            {
                b = amt;
            }

            [DiceFunction("b", Scope = FunctionScope.All, Timing = FunctionTiming.First)]
            public void B(FunctionContext context)
            {
                // adds b to the die
                context.Value = (context.Expression?.Value ?? 0) + b;
            }

            [DiceFunction("c", Scope = FunctionScope.Global)]
            private void C(FunctionContext context) { }
        }

        private class Invalid1
        {
            [DiceFunction("a")]
            public static int A(FunctionContext context)
            {
                return 0;
            }
        }

        private class Invalid2
        {
            [DiceFunction("a", Scope = FunctionScope.Roll, Timing = FunctionTiming.First)]
            public static void A(FunctionContext context) { }

            [DiceFunction("a", Scope = FunctionScope.All, Timing = FunctionTiming.First)]
            public static void B(FunctionContext context) { }
        }
    }
}
