using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pounds_to_Kilograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilogram = pounds * 0.453592;
            Console.WriteLine("The value of {0} pounds is {1} kilograms",pounds,kilogram);
            Console.ReadKey();
        }
    }
}
