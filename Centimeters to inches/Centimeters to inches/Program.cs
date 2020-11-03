using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centimeters_to_inches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value in centemeters: ");
            double centimeters = Convert.ToDouble(Console.ReadLine());
            double inches=centimeters/2.54;
            Console.WriteLine("The value of {0}centemeters is {1} inches",centimeters,inches);
            Console.ReadKey();
        }
    }
}
