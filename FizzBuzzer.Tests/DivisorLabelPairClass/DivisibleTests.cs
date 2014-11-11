using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzerTests.FizzBuzzerClass
{
    [TestClass]
    public class DivisibleTests
    {
        private const string trait = "DivisorLabelPairClass.DivisibleTests";


        [TestMethod]
        [TestCategory(trait)]
        public void Constructor_SetsPropertiesSimpleCase()
        {
            var pair = new DivisorLabelPair(8, "Label _eight_");
            Assert.AreEqual(pair.Divisor, 8);
            Assert.AreEqual(pair.Label, "Label _eight_");
        }

        [TestMethod]
        [TestCategory(trait)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_DoesNotAllowZeroDivisor()
        {
            var pair = new DivisorLabelPair(0, "my label");
            bool actual = pair.IsDivisible(145);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void Constructor_AllowNegativeDivisor()
        {
            var pair = new DivisorLabelPair(-5, "my label");
            Assert.AreEqual(pair.Divisor, -5);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void Constructor_AllowsEmptyLabel()
        {
            var pair = new DivisorLabelPair(12, "");
            Assert.AreEqual(pair.Label, string.Empty);
        }

        [TestMethod]
        [TestCategory(trait)]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_DoesNotAllowAllowNullLabel()
        {
            var pair = new DivisorLabelPair(12, null);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void IsDivisible_WorksInSimpleCaseTrue()
        {
            var pair = new DivisorLabelPair(12, "even dozen");
            bool expected = true;
            bool actual = pair.IsDivisible(144);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void IsDivisible_WorksInSimpleCaseFalse()
        {
            var pair = new DivisorLabelPair(12, "even dozen");
            bool expected = false;
            bool actual = pair.IsDivisible(145);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void LabelIfDivisible_WorksInSimpleCaseTrue()
        {
            var pair = new DivisorLabelPair(12, "even dozen");
            string expected = "even dozen";
            string actual = pair.LabelIfDivisible(144);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void LabelIfDivisible_WorksInSimpleCaseFalse()
        {
            var pair = new DivisorLabelPair(12, "even dozen");
            string expected = "";
            string actual = pair.LabelIfDivisible(145);
            Assert.AreEqual(expected, actual);
        }
    }
}
