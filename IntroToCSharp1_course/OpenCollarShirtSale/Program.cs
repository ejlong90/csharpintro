// Eric Long - 5/10/2023

using static System.Console;

namespace OpenCollarShirtSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wholesalePrice;  // Price of shirt
            double discountApplied; // amount of discount as a percent
            double discountPrice; // shirt Price with discount
            double discount; // amount of discount

            wholesalePrice = 41.0;
            discountApplied = 0.15;
            discount = wholesalePrice * discountApplied;
            discountPrice = wholesalePrice - discount;

            WriteLine("Item: Open Collar Running Shirt");
            WriteLine("Wholesale Price of item: {0:c}", wholesalePrice);
            WriteLine("Discount applied: {0:C}", discount);
            WriteLine("Discount rate: {0:P}", discountApplied);
            WriteLine("Net price of the item: {0:c}", discountPrice);
        }
    }
}