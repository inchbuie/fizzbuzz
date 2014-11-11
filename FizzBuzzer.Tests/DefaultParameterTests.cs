using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzerTests
{
    [TestClass]
    public class DefaultParameterTests
    {
        private const string trait = "DefaultParameterTests";

        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_ShouldNotBeNull()
        {
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange();
            Assert.IsNotNull(actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_CountShouldMatch()
        {
            var fizzBuzzer = new FizzBuzzer();
            List<string> actual = fizzBuzzer.CheckRange();
            Assert.AreEqual(100, actual.Count);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_ResultsShouldBeNewLineTerminated()
        {
            int value = 3;
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.IsTrue(actual.EndsWith(Environment.NewLine));
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_3ShouldFizz()
        {
            int value = 3;
            var expected = string.Format("{0}fizz{1}", value, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[value-1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_5ShouldBuzz()
        {
            int value = 5;
            var expected = string.Format("{0}buzz{1}", value, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_15ShouldFizzBuzz()
        {
            int value =15;
            var expected = string.Format("{0}fizzbuzz{1}", value, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_ShouldBe100Total()
        {
            var expected = 100;
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_MinShouldBe1()
        {
            int value = 1;
            var expected = string.Format("{0}{1}", value, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void DefaultParameters_MaxShouldBe100()
        {
            int value = 100;
            var expected = string.Format("{0}buzz{1}", value, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer();
            var actual = fizzBuzzer.CheckRange()[value - 1];
        }
    }
}
