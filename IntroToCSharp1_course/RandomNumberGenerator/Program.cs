// Eric Long - 5/11/2023
// Generate 10 random real numbers, between 0 and 200. One at a time.

using static System.Console;
using static System.Math;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int randomNum;
            int i = 0;

            while (i < 10)
            {

                randomNum = r.Next(0, 200);


                i++;
                if (randomNum > 100)
                {
                    WriteLine(randomNum);
                }

            }
            ReadKey();
        }
    }
}