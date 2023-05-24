

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double counter = 1;

            do
            {
                Console.WriteLine($"The sum of {counter} + 5");
                Console.WriteLine(counter + 5);
                Console.WriteLine("Please press Enter");
                Console.ReadKey();
                counter++;
            } while (counter > 0);
        }
    }
}