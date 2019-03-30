using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Shape
    {
        public string name;
        public abstract int CalculateArea();
    }
    class Square : Shape
    {
        private int length;
        private int width;


        public Square(int length, int width)
        {
            this.name = "square";
            this.length = length;
            this.width = width;
        }

        public override int CalculateArea()
        {
            int area = this.length * this.width;
            return area;
        }
    }
    class Triangle : Shape
    {
        private int baseLength;
        private int height;


        public Triangle(int baseLength, int height)
        {
            this.name = "triangle";
            this.baseLength = baseLength;
            this.height = height;
        }

        public override int CalculateArea()
        {
            int area = this.baseLength * this.height / 2;
            return area;
        }
    }
    class Circle : Shape
    {
        private double radius;
        
        public Circle(double r)
        {
            this.name = "circle";
            this.radius = r;
        }
        public override int CalculateArea()
        {
            int area = (int)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
    }
}
