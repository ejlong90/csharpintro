// Eric Long - 5/10/2023

using static System.Console;
using static System.Math;

namespace CylinderCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volume; // volume of cylinder
            double surface; // surface area of cylinder
            double radius;
            double height;

            WriteLine("Welcome to Cylinder Calculator 1.0");

            WriteLine("Enter the cylinder's radius");
            radius = double.Parse(ReadLine()); // Possible Null Reference

            WriteLine("Enter the cylinder's height");
            height = double.Parse(ReadLine()); // Possible Null Reference

            volume = Math.PI * radius * radius * height;
            surface = 2 * Math.PI * radius * (radius + height);
            WriteLine("Cylinder's volume is: " + volume);
            WriteLine("Cylinder's surface area is: " + surface);
            ReadKey();
        }
    }
}
