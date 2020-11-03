using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_area_and_volume_of_a_sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the sphere: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double pi=3.142;
            double volume=(4/3)*pi*(radius*radius*radius);
            double surfacearea=4*pi*(radius*radius);
            Console.WriteLine("The volume of the sphere is {0} and the surface area is {1} ", volume, surfacearea);
            Console.ReadKey();
        }
    }
}
