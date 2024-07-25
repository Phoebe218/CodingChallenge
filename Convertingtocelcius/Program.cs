using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converting to Celsius

            int fahrenheit = 89;
            decimal temperature1 = ((fahrenheit - 32) * 5m / 9);
            Console.WriteLine("The temperature is " + temperature1 + " degrees Celsius");

            // Using Math.Round to round the temperature
            int fahrenheit2 = 89;
            decimal temperature2 = ((fahrenheit2 - 32m) * 5m / 9m);
            Console.WriteLine("The temperature is " + Math.Round(temperature2) + " degrees Celsius");
        }
    }
}

