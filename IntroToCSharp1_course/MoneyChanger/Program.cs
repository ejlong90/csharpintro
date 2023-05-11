//Eric Long - 5/10/2023

using static System.Console;

namespace MoneyChanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingAmount; // starting amount as pennies.
            int dollars;
            int quarters;
            int dimes;
            int nickels;
            int pennies;

            startingAmount = 1156; //converting starting amount to dollars
            dollars = startingAmount / 100; //finding the remainder.
            pennies = startingAmount % 100; // finding the remaining pennies. 
            quarters = pennies / 25; // finding the amount in quarters.
            dimes = startingAmount / 10;
            dimes = startingAmount % 10;
            nickels = pennies / 5;
            pennies = pennies % 5;



            WriteLine("Amount of money to be changed: " + startingAmount);
            WriteLine("Number of dollars: " + dollars);
            WriteLine("and Number of quarters: " + quarters);
            WriteLine("and Number of dimes: " + dimes);
            WriteLine("and Number of nickels: " + nickels);
            WriteLine("and Number of pennies: " + pennies);
            ReadKey();
        }
    }
}