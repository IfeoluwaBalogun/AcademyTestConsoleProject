using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTestConsoleProject
{
    internal class ArithmeticMethod
    {
        public void perfomSubtraction()
        {
            Console.WriteLine("Enter first value");
            decimal.TryParse(Console.ReadLine(), out decimal firstValue);
            Console.WriteLine("Enter second value");
            decimal.TryParse(Console.ReadLine(), out decimal secondValue);
            decimal sum = firstValue + secondValue;
            Console.WriteLine($"\nThe difference is {decimal.Round(sum, 2)}");
           
        }
    }
}
