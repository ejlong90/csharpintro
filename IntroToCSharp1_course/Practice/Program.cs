// From Progressive Intro to C# course - 5/9/2023.


using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata;
using static System.Console;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 32; // Data Type = Integer.
            //char myChar = 'A'; // single quotes are needed for the char data type.
            //float totalAmount = 23.57f; // the suffix f is needed when using a float.
            /*  double distanceToTheMoon = 3.84 + e5;   in KMs
            - same as 3.84 * 10 to the 5th power. */
            //double lengthOfRoom = 12.5;
            //double widthOfRooom = 10.75;
            //string studentName = "Eric";


            //WriteLine(age);
            //WriteLine(myChar);
            //WriteLine(totalAmount);
            //WriteLine(lengthOfRoom);
            //WriteLine(widthOfRooom);
            //WriteLine(studentName);

            //WriteLine(distanceToTheMoon);



            /* int a;
            int b;
            a = 3;
            b = 4;
            a = a + b;
            a = 9;
            a = a + b;

            WriteLine(a);
            WriteLine(a);
            ReadKey(); 
            */

            /* int result = 1 + 2 - 3 + 4 - 5 * 6; // result = -26
             WriteLine(result);
             ReadKey(); */


            /* Math.Pow (double, double) - calculates exponents, arguments are double
               MathF.Pow (float, float) - calculates exponents, does not need double arguments
               Math.Sqrt (double) - calculates sqaure root of a double
               MathF.Sqrt (float) - calculates square root of a float
            */

            /* float radius = 4.0f;
             float pi = 3.1415926536f;
             float area;
             area = pi * radius * radius;
             WriteLine("Area of the circle = " + area);
             ReadKey();
            */

            double length = 0;
            double width = 0;
            double area = 0;
            string lengthAsString;
            string widthAsString;

            WriteLine("Please enter the length of the room: ");
            lengthAsString = ReadLine();
            length = double.Parse(lengthAsString);

            WriteLine("Please enter the width of the room: ");
            widthAsString = ReadLine();
            width = Convert.ToDouble(widthAsString);

            WriteLine(lengthAsString);
            WriteLine(widthAsString);
        }
    }
}