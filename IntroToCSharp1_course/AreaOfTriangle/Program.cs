// Eric Long - 5/10/2023

using static System.Console;

namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseOfTriangle = 5;
            int heightOfTriangle = 6;
            WriteLine("The base of the triangle is: " + baseOfTriangle + " inches.");
            WriteLine("The height of the triangle is: " + heightOfTriangle + " inches.");

            double areaOfTriangle = .5f * baseOfTriangle * heightOfTriangle;


            WriteLine("The area of the triangle is: " + areaOfTriangle + " inches.");
            ReadKey();
        }
    }
}