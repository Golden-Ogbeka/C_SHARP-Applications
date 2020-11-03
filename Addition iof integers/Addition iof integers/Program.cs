using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of__n__number_of_integers_with_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter an integer to add: ");
                sum = sum + Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The sum of the integers you entered is: {0}", sum);
            Console.ReadKey();
        }
    }
}
