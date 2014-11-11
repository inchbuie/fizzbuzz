using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// Parameter pair for use in FizzBuzzer
    ///   Holds the divisor (for checking if number is divisible by this)
    ///   and Label to add if the number is divisible
    ///   e.g. Label:fizz, Divisor:3
    /// </summary>
    public class DivisorLabel
    {
        public DivisorLabel(int divisor, string label)
        {
            if (null == label) throw new ArgumentNullException("label");
            Label = label;
            Divisor = divisor;
        }
        public string Label;
        public int Divisor;

        public bool IsDivisible(int value)
        {
            return (value % Divisor == 0);
        }
        public string LabelIfDivisible(int value)
        {

            return IsDivisible(value) ? Label : string.Empty;
        }
    }
}
