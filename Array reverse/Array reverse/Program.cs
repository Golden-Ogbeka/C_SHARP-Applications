using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the array: ");
            int lenght =Convert.ToInt32(Console.ReadLine()); //lenght of the array
            int[] array = new int[lenght];
            int counter = 1;
            for (int i = lenght-1; i >= 0;i--) 
            {
                Console.Write("Enter integer " + counter+ " for the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            for (int j=0;j<lenght;j++)
            {
                Console.Write(array[j]);
                Console.Write(" ");
            }
            Console.ReadKey();

        }
    }
}
