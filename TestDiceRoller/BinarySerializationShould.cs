﻿using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Dice;
using Dice.PbP;

namespace TestDiceRoller
{
    [TestClass]
    public class BinarySerializationShould : TestBase
    {
        [TestMethod]
        public void Successfully_RoundtripDieResult()
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            var die = new DieResult()
            {
                DieType = DieType.Fudge,
                NumSides = 3,
                Value = -2,
                Flags = DieFlags.Extra | DieFlags.Failure,
                Data = "Some Data"
            };

            formatter.Serialize(stream, die);
            stream.Seek(0, SeekOrigin.Begin);
            var die2 = (DieResult)formatter.Deserialize(stream);
            Assert.AreEqual(die, die2);
        }

        [TestMethod]
        public void Successfully_RoundtripRollResult()
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            var result = Roller.Roll("1d20+4");

            formatter.Serialize(stream, result);
            stream.Seek(0, SeekOrigin.Begin);
            var result2 = (RollResult)formatter.Deserialize(stream);
            Assert.AreEqual(result, result2);
        }

        [TestMethod]
        public void Successfully_RoundtripRollPost()
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            var post = new RollPost();

            post.AddRoll("1d20+4");
            post.AddRoll("2d6+3");
            post.Validate();

            formatter.Serialize(stream, post);
            stream.Seek(0, SeekOrigin.Begin);
            var post2 = (RollPost)formatter.Deserialize(stream);

            CollectionAssert.AreEqual(post.Pristine.ToList(), post2.Pristine.ToList());
            CollectionAssert.AreEqual(post.Stored.ToList(), post2.Stored.ToList());
            CollectionAssert.AreEqual(post.Current.ToList(), post2.Current.ToList());
            Assert.AreEqual(post.Diverged, post2.Diverged);
        }

        [TestMethod]
        public void Successfully_RoundtripRollPost_NoValidate()
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            var post = new RollPost();

            post.AddRoll("1d20+4");
            post.AddRoll("2d6+3");

            formatter.Serialize(stream, post);
            stream.Seek(0, SeekOrigin.Begin);
            var post2 = (RollPost)formatter.Deserialize(stream);

            CollectionAssert.AreEqual(post.Pristine.ToList(), post2.Pristine.ToList());
            CollectionAssert.AreEqual(post.Stored.ToList(), post2.Stored.ToList());
            CollectionAssert.AreEqual(post.Current.ToList(), post2.Current.ToList());
            Assert.AreEqual(post.Diverged, post2.Diverged);
        }
    }
}
