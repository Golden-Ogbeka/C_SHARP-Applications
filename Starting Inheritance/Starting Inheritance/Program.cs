using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting_Inheritance
{
    public class Base 
    {
        public virtual void Show()
        {
            Console.WriteLine("Show from base Class");
        }
    }
    public class Derived : Base 
    {
        public override void Show()
        {
            Console.WriteLine("Show from Derived Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            obj.Show();
            Console.ReadKey();
        }
    }
}
