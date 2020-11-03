using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsing_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 6;
            f1(a);//a is still the same 
            Console.WriteLine("a= {0}", a);
            f2(ref b);
            Console.WriteLine("b= {0}", b);
            Console.ReadKey();
        }
        static void f1(int x) 
        {
            x = x + 1;  //doesn't affect the a in main
        }
        static void f2(ref int x) 
        {
            x = x + 1;// afeects b because of the reference
        }
    }
}
