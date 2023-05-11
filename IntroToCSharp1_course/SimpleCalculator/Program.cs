// Eric Long - 5/11/2023

using static System.Console;
using static System.Math;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digitOne;
            int digitTwo;
            string mathOperator;
            int result = 0;

            Write("Enter the first digit. ");
            digitOne = int.Parse(Console.ReadLine());
            Write("Enter the second digit. ");
            digitTwo = int.Parse(Console.ReadLine());
            Write("Please enter the math operator. ");
            mathOperator = Console.ReadLine();

            switch (mathOperator)
            {
                case "+":
                    result = digitOne + digitTwo;
                    break;
                case "-":
                    result = digitOne - digitTwo;
                    break;
                case "*":
                    result = digitOne * digitTwo;
                    break;
                case "/":
                    result = digitOne / digitTwo;
                    break;
                case "^":
                    result = (int)Math.Pow(digitOne, digitTwo);
                    break;
                default:
                    WriteLine("Unknown Operator");
                    break;
            }
            WriteLine("Result of the expression = " + result);
            ReadKey();

        }
    }
}