using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Taxi
    {
        public bool isInitialized;
        public string colour;
        public static int noofwheels = 4;
        public Taxi()                       //default constructor
        {
            isInitialized = true;
        }
        public Taxi(bool a,string c) //non default constructor
        {
            isInitialized = a;
            colour = c;
        }
    }
    class TestTaxi
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();
            Console.WriteLine("{0}\n{1}", t.isInitialized, Taxi.noofwheels);
            Taxi x = new Taxi(false,"Yellow");
            Console.WriteLine("{0}\n{1}\n{2}",x.isInitialized,x.colour,Taxi.noofwheels);
            //you  don't need to create an object to call the noofwheels that is static.
            Console.ReadKey();
        }
    }
}
