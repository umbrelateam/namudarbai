using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            Console.Write("Enter the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());

            double a;
            BackToA:
            Console.Write("Enter the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a cant be 0!");
                goto BackToA;
            }
            double c;
            Console.Write("Enter the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            double d = b * b - 4 * a * c;
            double x1, x2, x;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.Write("Roots of quadratic equation: {0} or {1} ", x1, x2);
            }
            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.Write("Root of quadratic equation: " + x);
            }
            else if (d < 0)
            {
                Console.Write("The quadratic equation has no solutions.");
            }
            // ax^2 + bx +- c = 0
            Console.ReadLine();
        }
        
    }
}         