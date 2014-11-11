using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// 
    /// </summary>
    public class FizzBuzzer
    {
        const int defaultMin = 1;
        const int defaultMax = 100;

        public int Min;
        public int Max;
        /// <summary>
        /// Property to control whether the value is printed in addition to the
        ///  replacement label when there is a divisor hit
        /// </summary>
        public bool ShowValue= true;

        public List<DivisorLabelPair> DivisorLabels;

        /// <summary>
        /// Constructed object will have default label/divisor pairs
        ///   (3:fizz, 5:buzz)
        /// </summary>
        /// <param name="min">Start of range of numbers to check (optional, default=1)</param>
        /// <param name="max">End of range of numbers to check (optional, default=100)</param>
        public FizzBuzzer(int min = defaultMin, int max = defaultMax)
        {
            if (min < 0) throw new ArgumentException("Minimum range value cannot be negative");
            if (max < 1) throw new ArgumentException("Maximum range value must be positive");
            if (min <= max)
            {
                //normal
                Min = min;
                Max = max;
            }
            else
            {
                // they switched the parameters
                Min = max;
                Max = min;
            }
            if (null == DivisorLabels)
            {
                DivisorLabels = new List<DivisorLabelPair>();
                AddDivisorLabelPair(3, "fizz");
                AddDivisorLabelPair(5, "buzz");
            }
        }
        /// <summary>
        /// Constructed object will have provided label/divisor pairs
        /// </summary>
        /// <param name="min">Start of range of numbers to check (optional, default=1)</param>
        /// <param name="max">End of range of numbers to check (optional, default=100)</param>
        public FizzBuzzer(List<DivisorLabelPair> labelsForDivisors, int min = defaultMin, int max = defaultMax):this(min,max)
        {
            DivisorLabels = labelsForDivisors;
        }

        public List<string> CheckRange()
        {
            var results = new List<string>();
            StringBuilder resultForEach;
            for (int i = Min; i <= Max; i++)
            {
                resultForEach = new StringBuilder();
                //only add number if option is true
                if (ShowValue) resultForEach.Append(i);
                foreach (var divisorLabelPair in DivisorLabels)
                {
                    resultForEach.Append(divisorLabelPair.LabelIfDivisible(i));
                }
                resultForEach.Append(Environment.NewLine);
                results.Add(resultForEach.ToString());
            }
            return results;
        }

        public void ClearDivisorLabels()
        {
            DivisorLabels.Clear();
        }

        public void SetDivisorLabelPairs(List<DivisorLabelPair> divisorLabels)
        {
            if (null != divisorLabels) DivisorLabels = divisorLabels;
        }

        public void AddDivisorLabelPair(int divisor, string label)
        {
            if (null == DivisorLabels) DivisorLabels = new List<DivisorLabelPair>();
            var pair = new DivisorLabelPair(divisor, label);
            if (!DivisorLabels.Contains(pair))
            {
                DivisorLabels.Add(pair);
            }
        }

        public void RemoveDivisorLabelPair(DivisorLabelPair divisorLabel)
        {
            if (null != DivisorLabels && DivisorLabels.Contains(divisorLabel))
            {
                DivisorLabels.Remove(divisorLabel);
            }
        }
    }
}
