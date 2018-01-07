/* 
 * 03. Miles to Kilometers
 * 
 * Write a program, which converts miles to kilometers. Format the output to the 2nd decimal place.
 * Note: 1 mile == 1.60934 kilometers
 * 
 * Example
 * Input   Output    Input   Output    Input    Output
 * 60      96.56     1       1.61      52.1113  83.86
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace MilesToKilometers
{
    class MainClass
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}