using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEquatable<T> 
    {
        bool Equals(T obj);
    }
    public class Car : IEquatable<Car>
    {
        public string Make;
        public string Model;
        public string Year;
        public Car(string a, string g, string f) 
        {
            Make = a;
            Model = g;
            Year = f;
        }
        public bool Equals(Car car)
        {
            if (this.Make == car.Make && this.Model == car.Model && this.Year == car.Year)//this is a keyword that refers to the object that you use to invoke that method
            {
                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Audi = new Car("Audi", "80", "1982");
            Car Toyota = new Car("Toyota", "Camry", "2016");
            bool result = Audi.Equals(Toyota);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
