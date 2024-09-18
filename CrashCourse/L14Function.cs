using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse
{
    internal class L14Function
    {
        public static void Lesson14()
        {
            double radius, length, width;

            Console.WriteLine("\n\nFinding the Area of the Circle and Rectangle!\n");

            Console.Write("Radius of the Circle    : ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of the Rectangle :");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Width of the Rectangle  : ");
            width = Convert.ToDouble(Console.ReadLine());


            Shape circle = new Circle(radius);
            Console.WriteLine("\nThe area of the circle is: " + circle.CalculateArea());

            Shape rectangle = new Rectangle(length, width);
            Console.WriteLine("The area of the rectangle is: " + rectangle.CalculateArea());

            Console.WriteLine("\n\n Simple code for Abstraction \n");
        }
    }
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
}
