using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        class Shape
        {
            protected int width;
            protected int height;
            public Shape()
            {
                width = 4;
                height = 8;
            }
            public Shape(int w, int h)
            {
                width = w;
                height = h;
            }
            public void setWidth(int w) //another way of assigning width 
            {
                width = w;
            }
            public void setHeight(int h)    //another way of assigning height
            {
                height = h;
            }
        }

        // Derived class
        class Rectangle : Shape
        {
            public Rectangle() : base() //base() refers to the default constructor of the base class Shape
            {

            }
            public Rectangle(int width, int height) : base(width, height) //base() refers to the non default constructor of the base class Shape
            {

            }
            public int getArea()
            {
                return (width * height);
            }
        }
            static void Main(string[] args)
            {
                Rectangle Rect1 = new Rectangle();

                // Print the area of the object with default values.
                Console.WriteLine("Total area: {0}", Rect1.getArea());
                Rect1.setWidth(5);
                Rect1.setHeight(7);
                // Print the area of the object.
                Console.WriteLine("Total area: {0}", Rect1.getArea());
                Rectangle Rect2 = new Rectangle(5, 8);
                // Print the area of the object.
                Console.WriteLine("Total area: {0}", Rect2.getArea());
                Console.ReadKey();
            }
        }
    }
