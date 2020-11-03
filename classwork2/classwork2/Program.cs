using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork2
{
    class Program
    {
        static decimal SumOfBooks(decimal []x) 
        {
            decimal sum = 0;
            for (int i = 0; i < x.Length;i++ )
            {
                sum = sum + x[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            decimal[] books = {4,1,7,2,5 };
            decimal result=SumOfBooks(books);
            Console.WriteLine("The result is {0}",result);
            Console.ReadKey();
        }
    }
}
