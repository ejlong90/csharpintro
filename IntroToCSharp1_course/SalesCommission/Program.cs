// Eric Long - 5/11/2023

using static System.Console;
using static System.Math;

namespace SalesCommission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string employeeType;
            int itemsSold;
            double unitPrice;
            double sales;
            double commission;

            Write("Enter the amount of items Sold of the product");
            itemsSold = int.Parse(Console.ReadLine());
            Write("Enter the price per unit of the product");
            unitPrice = int.Parse(Console.ReadLine());
            Write("What is your employee Type");
            employeeType = Console.ReadLine();

            sales = itemsSold * unitPrice;

            if (employeeType == "C")
            {
                if (sales > 1000)
                {
                    commission = 100 + .03 * (sales / 1000);
                }
                else
                {
                    commission = 50 + .04 * sales;
                    {


            else if (employeeType == "S")
                        {
                            commission = .03 * sales;
                        }
                        else if (employeeType == "M")
                        {
                            if (sales > 1000)
                            {
                                commission = 50;
                            }
                        }
                        else
                            WriteLine("Unknown Employee Type");
                        WriteLine("Sales commision is = " + commission);
                        ReadKey();
                    }
                }
            }
        }
    }