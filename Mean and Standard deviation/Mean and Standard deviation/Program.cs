using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mean_and_Standard_deviation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of numbers: ");
            int n = Convert.ToInt32(Console.ReadLine()); //is amountof numbers
            int[] numbers=new int[n];
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter value " + counter + " in the array: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + numbers[i];
                counter++;
            }
            double mean = sum / n;
            double dev = 0;    //standard deviation
            for (int i = 0; i < n;i++ )
            {
                dev = Math.Pow((numbers[i] - mean), 2);
            }
            dev = Math.Sqrt(dev / n);
            Console.WriteLine("The mean is {0} and the standard deviation is {1}",mean,dev);
            Console.ReadKey();
        }
    }
}
