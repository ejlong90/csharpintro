// Eric Long - 5/11/2023

using System.ComponentModel.Design;
using static System.Console;

namespace DecisionMakingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Relational, Equality and Logical Operators ---
             == Equal to - Returns true if age is 30
             |= Not Equal to - Returns true if age is foo is not equal to MyStr
             < Less than - Returns true if age is less than 69
             <= Less than or Equal to - Returns true if age is 30
             == Equal to - Returns true if age is 30
             == Equal to - Returns true if age is 30
             == Equal to - Returns true if age is 30
             == Equal to - Returns true if age is 30
             == Equal to - Returns true if age is 30

             */

            char grade;
            Write("What id the score on this test?");
            double score = double.Parse(Console.ReadLine());
            if (score > 90)
            {
                grade = 'A';
            }
            else if (score > 80)
            {
                grade = 'B';
            }
            else if (score > 70)
            {
                grade = 'C';
            }
            else if (score > 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

        }
    }
}