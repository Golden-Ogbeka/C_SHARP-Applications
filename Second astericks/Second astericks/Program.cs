using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_astericks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < (2 * n); i = i++)
            {
                for (int j = 0; j <2*n-1; j++)
                {
                    Console.WriteLine("x");
                }
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
