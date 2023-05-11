// Eric Long - 5/11/2023

// Display all numbers from 1 to 50. (not 0 to 49). 
// Display "Fizz" if numbers is multiple of 3.
// Display Display Buzz if number is multiple of 5. 
// Display "FizzBuzz" if multiple of 3 and 5. 

using static System.Console;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    WriteLine("FIZZBUZZ");
                }
                else if (i % 5 == 0)
                {
                    WriteLine("BUZZ");
                }
                else if (i % 3 == 0)
                {
                    WriteLine("FIZZ");
                }
                else
                {
                    WriteLine(i);
                }
            }
        }
    }
}