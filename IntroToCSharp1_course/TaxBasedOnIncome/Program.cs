using static System.Console;

namespace TaxBasedOnIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Please enter your income: ");
            double myIncome = Double.Parse(Console.ReadLine());

            Console.Write("What is the tax rate in your state? ");
            double taxRate = Double.Parse(Console.ReadLine()) / 100;

            double takeHomePay = myIncome - (myIncome * taxRate);

            WriteLine("Your take home pay is: " + takeHomePay);



        }
    }
}