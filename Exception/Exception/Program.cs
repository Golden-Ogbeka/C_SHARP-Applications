using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                Console.WriteLine("Enter the first number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int z = Convert.ToInt32(Console.ReadLine());
                int k = y / z;

            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Dividing by zero?");
            }
            Console.ReadKey();
        
        }
    }
}
