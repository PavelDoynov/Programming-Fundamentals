/*
 * 05. Temperature Conversion
 * 
 * Create a method that converts a temperature from Fahrenheit to Celsius. Format the result to the 2nd decimal point.
 * Use the formula: (fahrenheit - 32) * 5 / 9.
 * 
 * Input:       Output:           Input:       Output:              Input:       Output:
 * 95           35.00             33.8         1.00                 -40          -40.00
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Temperature_Conversion
{
    class MainClass
    {
        public static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            FahrenheitToCelsius(fahrenheit);
        }

        public static void FahrenheitToCelsius (double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;

            Console.WriteLine("{0:f2}", celsius);
        }
    }
}
