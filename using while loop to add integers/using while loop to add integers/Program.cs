using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_while_loop_to_add_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers you want to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int sum = 0;
            while (i < num) {
                Console.WriteLine("Enter interger {0}: ", i+1);
                sum+=Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine("The sum of all the integers entered is: {0}", sum);
            Console.ReadKey();
        }
    }
}
