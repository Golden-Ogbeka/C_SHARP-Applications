using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Planet 
    {
        private string name;
        public Planet() { }
        public Planet(string name)
        {
            this.name = name;
        }
        public void enterName() 
        {
            string name;
            Console.WriteLine("Enter: ");
            name = Console.ReadLine();
            this.name = name;
        }
        public void printName() 
        {
            Console.WriteLine(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Planet var1 = new Planet();
            var1.enterName();
            var1.printName();
            Planet var2 = new Planet("Earth");
            var2.printName();
            Console.ReadKey();
        }
    }
}
