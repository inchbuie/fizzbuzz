using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // default arguments 
            //print number in range 1-100, fizz if divisible by 3, buzz if divisible by 5            
            FizzBuzzer buzzer = new FizzBuzzer();
            var results = buzzer.CheckRange();
            foreach(var line in results) Console.Write(line);

            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadLine();

            // custom arguments 
            //print number in range 3-65, FOUR if divisible by 4, touchdown! if divisible by 7, * if divisible by 9
            var customParams = new List<DivisorLabelPair>();
            customParams.Add(new DivisorLabelPair(4, "FOUR"));
            customParams.Add(new DivisorLabelPair(7, "touchdown"));
            customParams.Add(new DivisorLabelPair(9, "*"));
            FizzBuzzer customBuzzer = new FizzBuzzer(customParams, 3, 65);
            results = customBuzzer.CheckRange();
            foreach (var line in results) Console.Write(line);

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
