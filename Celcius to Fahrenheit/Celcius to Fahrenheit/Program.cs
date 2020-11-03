using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of trials: ");
            int trials = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trials; i++)
            {
                Console.WriteLine("Enter the value in Celsius: ");
                double C = Convert.ToDouble(Console.ReadLine());
                double F = ((9 * C) / 5) + 32;
                Console.WriteLine("The value of {0} degrees celsius is {1}degree fahrenheit.", C, F);
            }
            Console.ReadKey();
        }
    }
}
