using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzerTests.FizzBuzzerClass
{
    [TestClass]
    public class CustomParameterTests
    {
        private const string trait = "FizzBuzzerClass.CustomParameterTests";

        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_SingleNonDefaultLabelShouldWork()
        {
            int value = 3;
            string customLabel="Excelsior";
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>(){new DivisorLabelPair(value,customLabel)};
            var expected = string.Format("{0}{1}{2}", value, customLabel, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer(labelPairs);
            var actual = fizzBuzzer.CheckRange()[value-1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_SingleNonDefaultDivisorShouldWork()
        {
            int value = 18;
            string customLabel = "fizz";
            int customDivisor = 9;
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>() { new DivisorLabelPair(customDivisor, customLabel) };
            var expected = string.Format("{0}{1}{2}", value, customLabel, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer(labelPairs);
            var actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_ThreEntirelyCustomDivisorLabelsShouldWork()
        {
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>() 
            { 
                new DivisorLabelPair(8, "Ocho!") 
                ,new DivisorLabelPair(12, "Even Dozen")
                ,new DivisorLabelPair(43, "BigPrime") 
            };
            int value = 32;
            var expected = string.Format("{0}{1}{2}", value, labelPairs[0].Label, Environment.NewLine);
            var fizzBuzzer = new FizzBuzzer(labelPairs);
            var actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);
            
            value = 36;
            expected = string.Format("{0}{1}{2}", value, labelPairs[1].Label, Environment.NewLine);
            fizzBuzzer = new FizzBuzzer(labelPairs);
            actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);

            value = 43;
            expected = string.Format("{0}{1}{2}", value, labelPairs[2].Label, Environment.NewLine);
            fizzBuzzer = new FizzBuzzer(labelPairs);
            actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);

            value = 96;
            expected = string.Format("{0}{1}{2}{3}", value, labelPairs[0].Label, labelPairs[1].Label, Environment.NewLine);
            fizzBuzzer = new FizzBuzzer(labelPairs);
            actual = fizzBuzzer.CheckRange()[value - 1];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_CustomRange5ParametersShouldWork()
        {
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>() 
            { 
                new DivisorLabelPair(2, "two") 
                ,new DivisorLabelPair(3, "three")
                ,new DivisorLabelPair(4, "four") 
                ,new DivisorLabelPair(5, "five") 
                ,new DivisorLabelPair(6, "six") 
            };

            int value = 720; //2*3*4*5*6
            var expected = string.Format("{0}twothreefourfivesix{1}", value, Environment.NewLine);
            int customMin = 317;
            int customMax = 999;
            var fizzBuzzer = new FizzBuzzer(labelPairs, customMin, customMax);
            var actual = fizzBuzzer.CheckRange()[value - customMin];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_CustomRangeWithCustomDivisorLabels_FirstValueAsExpected()
        {
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>() 
            { 
                new DivisorLabelPair(2, "two") 
                ,new DivisorLabelPair(3, "three")
                ,new DivisorLabelPair(4, "four") 
                ,new DivisorLabelPair(5, "five") 
                ,new DivisorLabelPair(6, "six") 
            };

            int value = 317;
            var expected = string.Format("{0}{1}", value, Environment.NewLine);
            int customMin = 317;
            int customMax = 999;
            var fizzBuzzer = new FizzBuzzer(labelPairs, customMin, customMax);
            var actual = fizzBuzzer.CheckRange()[0];
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory(trait)]
        public void CustomParameter_CustomRangeWithCustomDivisorLabels_LastValueAsExpected()
        {
            List<DivisorLabelPair> labelPairs = new List<DivisorLabelPair>() 
            { 
                new DivisorLabelPair(2, "two") 
                ,new DivisorLabelPair(3, "three")
                ,new DivisorLabelPair(4, "four") 
                ,new DivisorLabelPair(5, "five") 
                ,new DivisorLabelPair(6, "six") 
            };

            int value = 999;
            var expected = string.Format("{0}three{1}", value, Environment.NewLine);
            int customMin = 317;
            int customMax = 999;
            var fizzBuzzer = new FizzBuzzer(labelPairs, customMin, customMax);
            var actual = fizzBuzzer.CheckRange()[value - customMin];
            Assert.AreEqual(expected, actual);
        }
    }
}
