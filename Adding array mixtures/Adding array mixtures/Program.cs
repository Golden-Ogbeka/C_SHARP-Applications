using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_array_mixtures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4,7,8};
            int sum = 0;
            int x=array.Length;
            for (int i = 0, j=array.Length-1; i < j; i++,j--) //to leave the middle value
            {
              sum += array[i] + array[j];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        
    }
}
