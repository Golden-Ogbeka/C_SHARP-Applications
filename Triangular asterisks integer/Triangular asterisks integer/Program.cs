using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangular_asterisks_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of rows: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
