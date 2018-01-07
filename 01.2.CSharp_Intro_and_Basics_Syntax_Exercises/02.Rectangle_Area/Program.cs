/* 
 * 02. Rectangle Area
 * 
 * Write a program, which calculates a rectangle’s area, based on its width and height. 
 * The width and height come as floating point numbers on the console, formatted to the 
 * 2nd character after the decimal point.
 * 
 * Example
 * Input     Output        Input     Output
 * 2         14.00         12.33     61.65
 * 7                       5
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace RectangleArea
{
    class MainClass
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double sum = width * height;

            Console.WriteLine($"{sum:f2}");
        }
    }
}