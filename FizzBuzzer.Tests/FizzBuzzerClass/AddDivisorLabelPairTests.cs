using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System.Collections.Generic;

namespace FizzBuzzerTests.FizzBuzzerClass
{
    [TestClass]
    public class AddDivisorLabelPairTests
    {
        private const string trait = "AddDivisorLabelPairTests";
        private FizzBuzzer fizzBuzzer;

        [TestInitialize]
        public void InitializeFizzBuzzerClass()
        {
            fizzBuzzer = new FizzBuzzer();
        }

        [TestMethod]
        [TestCategory(trait)]
        public void CanAddSingle()
        {
            //2 default parameters + 1 we will add
            int expected = 3;
            fizzBuzzer.AddDivisorLabelPair(7, "=Qwerty");
            Assert.AreEqual(expected, fizzBuzzer.DivisorLabels.Count);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void CanAddSingleWithExpectedData()
        {
            fizzBuzzer.AddDivisorLabelPair(7, "=Qwerty");
            var pair = fizzBuzzer.DivisorLabels[2];
            Assert.AreEqual(7, pair.Divisor);
            Assert.AreEqual("=Qwerty", pair.Label);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void CanAddThree()
        {
            //2 default parameters + 3 we will add
            int expected = 5;
            fizzBuzzer.AddDivisorLabelPair(7, "=Qwerty");
            fizzBuzzer.AddDivisorLabelPair(5, "ppppppppppp sadfffff");
            fizzBuzzer.AddDivisorLabelPair(6, "slfkjdf");
            Assert.AreEqual(expected, fizzBuzzer.DivisorLabels.Count);
        }

        [TestMethod]
        [TestCategory(trait)]
        public void CanAddThreeWithExpectedData()
        {
            List<KeyValuePair<int,string>> pairs = new List<KeyValuePair<int,string>>(3);
            pairs.Add(new KeyValuePair<int,string>(7, "=Qwerty"));
            pairs.Add(new KeyValuePair<int,string>(5, "ppppppppppp sadfffff"));
            pairs.Add(new KeyValuePair<int, string>(6, "slfkjdf"));
            //fizzBuzzer.AddDivisorLabelPair(5, "ppppppppppp sadfffff");
            //fizzBuzzer.AddDivisorLabelPair(6, "slfkjdf");
            fizzBuzzer.AddDivisorLabelPair(pairs[0].Key, pairs[0].Value);
            fizzBuzzer.AddDivisorLabelPair(pairs[1].Key, pairs[1].Value);
            fizzBuzzer.AddDivisorLabelPair(pairs[2].Key, pairs[2].Value);
            //ignore first two (default) pairs
            for (int i = 2; i < 5; i++)
            {
                var pair = fizzBuzzer.DivisorLabels[i];
                Assert.AreEqual(pairs[i-2].Key, pair.Divisor);
                Assert.AreEqual(pairs[i-2].Value, pair.Label);
            }
        }
    }
}
