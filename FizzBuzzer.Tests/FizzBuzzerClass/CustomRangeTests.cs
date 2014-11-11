using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzerTests.FizzBuzzerClass
{
    [TestClass]
    public class CustomRangeTests
    {
        private const string trait = "FizzBuzzerClass.CustomRangeTests";

        [TestMethod]
        [TestCategory(trait)]
        public void CustomRange_SwitchedParametersShouldBeAcceptedAndAutomaticallyCorrected()
        {
            int min = 65;
            int max = 27;
            var expected = min-max + 1;
            var fizzBuzzer = new FizzBuzzer(min, max);
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomRange_Passing0ForMinShouldBeAccepted()
        {
            int min = 0;
            int max = 27;
            var expected = max - min + 1;
            var fizzBuzzer = new FizzBuzzer(min, max);
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        [TestCategory(trait)]
        public void CustomRange_PassingNegativeForMinShouldThrowArgumentException()
        {
            int min = -9;
            int max = 27;
            var fizzBuzzer = new FizzBuzzer(min, max);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        [TestCategory(trait)]
        public void CustomRange_Passing0ForMaxShouldThrowArgumentException()
        {
            int min = 0;
            int max = 0;
            var fizzBuzzer = new FizzBuzzer(min, max);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        [TestCategory(trait)]
        public void CustomRange_PassingNegativeForMaxShouldThrowArgumentException()
        {
            int min = 66;
            int max = -192;
            var fizzBuzzer = new FizzBuzzer(min, max);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomRange_RangeOf1_ExpectedCount()
        {
            int min = 6;
            int max = 6;
            var expected = max - min + 1;
            var fizzBuzzer = new FizzBuzzer(min, max);
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomRange_ExpectedCount()
        {
            int min = 27;
            int max = 65;
            var expected = max - min + 1;
            var fizzBuzzer = new FizzBuzzer(min, max);
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomRange_BigRange_ExpectedCount()
        {
            int min = 5;
            int max = 30000;
            var expected = max-min+1;
            var fizzBuzzer = new FizzBuzzer(min, max);
            var actual = fizzBuzzer.CheckRange().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
