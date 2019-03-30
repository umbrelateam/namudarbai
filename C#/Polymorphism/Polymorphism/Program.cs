using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3, 10);
            Triangle triangle = new Triangle(27, 30);
            Circle circle = new Circle(3.54);
            Shape[] a = new Shape[3];
            a[0] = square;
            a[1] = triangle;
            a[2] = circle;
            foreach (Shape s in a)
            {
                Console.WriteLine("Area of {0}: {1} units", s.name, s.CalculateArea());
            }

            //Console.WriteLine("Area of {0}: {1} units", square.name, square.CalculateArea());
            //Console.WriteLine("Area of {0}: {1} units", triangle.name, triangle.CalculateArea());
            //Console.WriteLine("Area of {0}: {1} units", circle.name, circle.CalculateArea());
            Console.ReadKey();
        }
    }
}
