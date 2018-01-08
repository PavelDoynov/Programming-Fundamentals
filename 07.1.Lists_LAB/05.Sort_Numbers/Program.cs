/*
 * 05. Sort Numbers
 * 
 * Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
 * 
 * Example
 * Input      Output                        Input      Output
 * 8 2 7 3    2 <= 3 <= 7 <= 8              2 4 -9     -9 <= 2 <= 4
 * 
 * Hints
 * •   Use the built-in method List<T>.Sort().
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
