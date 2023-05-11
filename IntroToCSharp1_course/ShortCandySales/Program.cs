// Eric Long - 5/10/2023

using System.Diagnostics.CodeAnalysis;
using static System.Console;

namespace ShortCandySales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casesSold;
            int barsPerCase;
            double costPerBar;
            double wholesaleCost;

            Write("How many cases of candy did you have? ");
            casesSold = Convert.ToInt32(ReadLine());

            Write("How many bars were in the case? ");
            barsPerCase = Convert.ToInt32(ReadLine());

            Write("How much per bar are you charging? ");
            costPerBar = Convert.ToDouble(ReadLine()); // Convert to currency

            Write("How much was each case? ");
            wholesaleCost = Convert.ToDouble(ReadLine());// Convert to currency

            double candyCost = wholesaleCost * casesSold;
            double salesRevenue = costPerBar * (casesSold * barsPerCase) - candyCost;
            double studentGovFee = salesRevenue * 0.10;
            double clubProceeds = salesRevenue - studentGovFee;

            WriteLine("Number of cases of Candy = " + casesSold);
            WriteLine("Cost of a case = {0:c}", wholesaleCost);
            WriteLine("Number of Bars per case = " + barsPerCase);
            WriteLine("Sale price of a candy bar = {0:c}", costPerBar);
            WriteLine("Net proceeds from candy sales = {0:c}", clubProceeds);
            ReadKey();
        }
    }
}