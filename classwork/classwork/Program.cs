using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 10, 7, 2, 5 };
            Maximim(array);
            Console.ReadKey();
        }
        
        static void Maximim(int[]x) 
        {
            int max = x[0];
            for (int i = 0; i < x.Length;i++ )
            {
                if (max < x[i]) 
                {
                    max = x[i];
                }
            }
            Console.WriteLine("The maximum value in the array is: {0}", max);
        }
        
        
    }
}
