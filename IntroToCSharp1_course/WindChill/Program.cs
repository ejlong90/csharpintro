// Eric Long - 5/11/2023

using static System.Console;
using static System.Math;

namespace WindChill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentTemperature;
            double windSpeed;
            double tWindChill;

            Write("Enter temperate in Farenheit.");
            currentTemperature = double.Parse(ReadLine());
            if (currentTemperature < -58)
            {
                Write("Temperature is too low to determine windchill");
                return;
            }

            if (currentTemperature > 41)

            {
                WriteLine("Temperature is too high");
                return;
            }

            WriteLine("What is the current wind speed in MPH? ");
            windSpeed = double.Parse(ReadLine());
            if (windSpeed < 2)
            {
                Write("The current wind speed is too low");
                return;
            }
            if (windSpeed > 2)
                tWindChill = 35.74 + 0.6215 * currentTemperature - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * currentTemperature * Math.Pow(windSpeed, 0.16);
            WriteLine("The wind chill is {0:f4}", tWindChill);
            ReadKey();
            {

            }


        }
    }
}