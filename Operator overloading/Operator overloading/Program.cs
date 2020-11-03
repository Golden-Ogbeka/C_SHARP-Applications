using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class A 
    {
        private int a;
        private int b;
        public A() 
        {

        }
        public A(int x, int y) 
        {
            a=x;
            b=y;
        }
        public static A operator + (A x,A y)
        {
            A z = new A();
            z.a = x.a + y.a;
            z.b = x.b + y.b;
            Console.WriteLine("x:{0},y:{1}",z.a,z.b);
            return z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A m = new A(2, 5);
            A n = new A(4, 7);
            A p = m + n;
            Console.ReadKey();
        }
    }
}
