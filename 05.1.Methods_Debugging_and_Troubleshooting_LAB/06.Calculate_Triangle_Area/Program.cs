/*
 * 06. Calculate Triangle Area
 * 
 * Create a method that calculates and returns the area of a triangle by given base and height:
 * 
 * Example
 * Input:      Output:
 * 3           6
 * 4
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Calculate_Triangle_Area
{
    class MainClass
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = Area(height, width);
            Console.WriteLine("{0}", area);
        }

        public static double Area (double height, double width)
        {
            return (height * width) / 2; 
        }
    }
}
