

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double counter = 1;

            do
            {
                Console.Write($"The square root of {counter} is ");
                Console.WriteLine(Math.Sqrt(counter));
                Console.WriteLine("Please press Enter");
                Console.ReadKey();
                counter++;
            } while (counter > 0);
        }
    }
}