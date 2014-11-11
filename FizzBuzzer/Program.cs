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
            FizzBuzzer buzzer = new FizzBuzzer(1, 100);
            buzzer.CheckRange();

            Console.ReadLine();
        }
    }
}
