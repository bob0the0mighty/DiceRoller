﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Dice;

namespace TestDiceRoller
{
    [TestClass]
    public class RollerShould : TestBase
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowArgumentNullExpression_WhenNullDiceExpr()
        {
            Roller.Roll(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenTooFewMaxDice()
        {
            var conf = new RollerConfig() { MaxDice = 0 };
            Roller.Roll("1d20", conf);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenTooFewMaxSides()
        {
            var conf = new RollerConfig() { MaxSides = 0 };
            Roller.Roll("1d20", conf);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenTooLowMaxRecursionDepth()
        {
            var conf = new RollerConfig() { MaxRecursionDepth = -1 };
            Roller.Roll("1d20", conf);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ThrowInvalidOperationException_WhenTooLowMaxRerolls()
        {
            var conf = new RollerConfig() { MaxRerolls = -1 };
            Roller.Roll("1d20", conf);
        }

        [TestMethod]
        public void Successfully_CompareTwoRolls_Equal()
        {
            var res1 = Roller.Roll("3d20", Roll9Conf);
            var res2 = Roller.Roll("3d20", Roll9Conf);
            Assert.IsTrue(res1 == res2);
        }

        [TestMethod]
        public void Successfully_CompareTwoDice_Equal()
        {
            var res = Roller.Roll("2d20", Roll9Conf);
            Assert.IsTrue(res.Values[0] == res.Values[2]);
        }

        [TestMethod]
        public void Successfully_CompareTwoRolls_NotEqual()
        {
            var res1 = Roller.Roll("3d20", Roll9Conf);
            var res2 = Roller.Roll("4d20", Roll9Conf);
            Assert.IsTrue(res1 != res2);
        }

        [TestMethod]
        public void Successfully_CompareTwoDice_NotEqual()
        {
            var res = Roller.Roll("2d20", new RollerConfig() { GetRandomBytes = GetRNG(0, 1) });
            Assert.IsTrue(res.Values[0] != res.Values[2]);
        }

        [TestMethod]
        public void Successfully_CompareTwoRolls_Equals()
        {
            var res1 = Roller.Roll("3d20", Roll9Conf);
            var res2 = Roller.Roll("3d20", Roll9Conf);
            Assert.AreEqual(res1, res2);
            Assert.AreNotSame(res1, res2);
        }

        [TestMethod]
        public void Successfully_CompareTwoDice_Equals()
        {
            var res = Roller.Roll("2d20", Roll9Conf);
            Assert.AreEqual(res.Values[0], res.Values[2]);
            Assert.AreNotSame(res.Values[0], res.Values[2]);
        }

        [TestMethod]
        public void Successfully_CompareTwoRolls_HashCodes()
        {
            var res1 = Roller.Roll("3d20", Roll9Conf);
            var res2 = Roller.Roll("3d20", Roll9Conf);
            Assert.AreEqual(res1.GetHashCode(), res2.GetHashCode());
        }

        [TestMethod]
        public void Successfully_CompareTwoDice_HashCodes()
        {
            var res = Roller.Roll("2d20", Roll9Conf);
            Assert.AreEqual(res.Values[0].GetHashCode(), res.Values[2].GetHashCode());
        }

        [TestMethod]
        public void Successfully_PreserveMetadata()
        {
            var metadata = "foobar";
            var res = Roller.Roll("1d20", Roll9Conf, new RollData() { Metadata = metadata });
            Assert.AreEqual(metadata, (string)res.Metadata);
        }

        [TestMethod]
        public void Successfully_PreserveMetadata_Serialization()
        {
            var metadata = "foobar";
            var stream = new MemoryStream();
            var res = Roller.Roll("1d20", Roll9Conf, new RollData() { Metadata = metadata });

            res.Serialize(stream);
            stream.Seek(0, SeekOrigin.Begin);
            var res2 = RollResult.Deserialize(stream);

            Assert.AreEqual(metadata, (string)res2.Metadata);
        }
    }
}
