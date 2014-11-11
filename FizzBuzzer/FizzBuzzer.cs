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

        public List<DivisorLabel> DivisorLabels;

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
                DivisorLabels = new List<DivisorLabel>();
                AddDivisorLabelPair(3, "fizz");
                AddDivisorLabelPair(5, "buzz");
            }
        }
        public FizzBuzzer(List<DivisorLabel> labelsForDivisors, int min = defaultMin, int max = defaultMax):this(min,max)
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

        public void AddDivisorLabelPair(int divisor, string label)
        {
            if (null == DivisorLabels) DivisorLabels = new List<DivisorLabel>();
            var pair = new DivisorLabel(divisor, label);
            if (!DivisorLabels.Contains(pair))
            {
                DivisorLabels.Add(pair);
            }
        }
    }
}
