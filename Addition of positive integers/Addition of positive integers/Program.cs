using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_positive_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;
            do
            {
                Console.WriteLine("Enter only positive integers: ");
                input = Convert.ToInt32(Console.ReadLine());
                sum =sum+input;

            }
            while (input > 0);
            Console.WriteLine("The total of the positive integers is: {0}", sum);
            Console.ReadKey();
        }
    }
}
