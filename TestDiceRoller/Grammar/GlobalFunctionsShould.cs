﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Dice;

namespace TestDiceRoller.Grammar
{
    [TestClass]
    public class GlobalFunctionsShould : TestBase
    {
        [TestMethod]
        public void Successfully_Floor()
        {
            EvaluateRoll("floor(1.5)", Roll9Conf, 0, "floor(1.5) => floor(1.5) => 1");
        }

        [TestMethod]
        public void Successfully_FloorMixedCase()
        {
            EvaluateRoll("FLooR(1.5)", Roll9Conf, 0, "floor(1.5) => floor(1.5) => 1");
        }

        [TestMethod]
        public void Successfully_Ceiling()
        {
            EvaluateRoll("ceil(1.5)", Roll9Conf, 0, "ceil(1.5) => ceil(1.5) => 2");
        }

        [TestMethod]
        public void Successfully_RoundBelowPoint5()
        {
            EvaluateRoll("round(1.4)", Roll9Conf, 0, "round(1.4) => round(1.4) => 1");
        }

        [TestMethod]
        public void Successfully_RoundAbovePoint5()
        {
            EvaluateRoll("round(1.6)", Roll9Conf, 0, "round(1.6) => round(1.6) => 2");
        }

        [TestMethod]
        public void Successfully_RoundAtPoint5()
        {
            EvaluateRoll("round(1.5)", Roll9Conf, 0, "round(1.5) => round(1.5) => 2");
        }

        [TestMethod]
        public void Successfully_Abs()
        {
            EvaluateRoll("abs(-0.5)", Roll9Conf, 0, "abs(-0.5) => abs(-0.5) => 0.5");
        }

        [TestMethod]
        public void Successfully_Max()
        {
            var conf = new RollerConfig() { GetRandomBytes = GetRNG(4, 9) };
            EvaluateRoll("max(1d20, 1d20)", conf, 2, "max(1d20, 1d20) => max(5*, 10) => 10");
        }

        [TestMethod]
        public void Successfully_Min()
        {
            var conf = new RollerConfig() { GetRandomBytes = GetRNG(4, 9) };
            EvaluateRoll("min(1d20, 1d20)", conf, 2, "min(1d20, 1d20) => min(5, 10*) => 5");
        }

        [TestMethod]
        public void Successfully_If_Success_NoElse()
        {
            EvaluateRoll("if(1, =1, 2)", Roll9Conf, 0, "if(1, =1, 2) => (2) => 2");
        }

        [TestMethod]
        public void Successfully_If_Failure_NoElse()
        {
            EvaluateRoll("if(2, =1, 2)", Roll9Conf, 0, "if(2, =1, 2) => (0) => 0");
        }

        [TestMethod]
        public void Successfully_If_Success_WithElse()
        {
            EvaluateRoll("if(1, =1, 2, 3)", Roll9Conf, 0, "if(1, =1, 2, 3) => (2) => 2");
        }

        [TestMethod]
        public void Successfully_If_Failure_WithElse()
        {
            EvaluateRoll("if(2, =1, 2, 3)", Roll9Conf, 0, "if(2, =1, 2, 3) => (3) => 3");
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When0ArgFloor()
        {
            EvaluateRoll("floor()", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When2ArgFloor()
        {
            EvaluateRoll("floor(1, 2)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArgFloor()
        {
            EvaluateRoll("floor(=1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When0ArgCeiling()
        {
            EvaluateRoll("ceil()", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When2ArgCeiling()
        {
            EvaluateRoll("ceil(1, 2)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArgCeiling()
        {
            EvaluateRoll("ceil(=1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When0ArgRound()
        {
            EvaluateRoll("round()", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When2ArgRound()
        {
            EvaluateRoll("round(1, 2)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArgRound()
        {
            EvaluateRoll("round(=1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When0ArgAbs()
        {
            EvaluateRoll("abs()", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When2ArgAbs()
        {
            EvaluateRoll("abs(1, 2)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArgAbs()
        {
            EvaluateRoll("abs(=1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When1ArgMax()
        {
            EvaluateRoll("max(1d20)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When3ArgMax()
        {
            EvaluateRoll("max(1d20, 1d20, 1d20)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg1Max()
        {
            EvaluateRoll("max(=1, 1d20)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg2Max()
        {
            EvaluateRoll("max(1d20, =1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When1ArgMin()
        {
            EvaluateRoll("min(1d20)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When3ArgMin()
        {
            EvaluateRoll("min(1d20, 1d20, 1d20)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg1Min()
        {
            EvaluateRoll("min(=1, 1d20)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg2Min()
        {
            EvaluateRoll("min(1d20, =1)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When2ArgIf()
        {
            EvaluateRoll("if(1d20, =9)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArity_When5ArgMin()
        {
            EvaluateRoll("if(1d20, =9, 5, 6, 7)", Roll9Conf, DiceErrorCode.IncorrectArity);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg1If()
        {
            EvaluateRoll("if(=1, =2, 3)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenNotComparisonArg2If()
        {
            EvaluateRoll("if(1d20, 2, 3)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg3If()
        {
            EvaluateRoll("if(1d20, =2, =3)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }

        [TestMethod]
        public void ThrowsIncorrectArgType_WhenComparisonArg4If()
        {
            EvaluateRoll("if(1d20, =2, 3, =4)", Roll9Conf, DiceErrorCode.IncorrectArgType);
        }
    }
}
