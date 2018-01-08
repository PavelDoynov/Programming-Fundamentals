/*
 * 03. Sum Adjacent Equal Numbers
 * 
 * Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
 * •   After two numbers are summed, the obtained result could be equal to some of its neighbors and should be 
 *       summed as well (see the examples below).
 * •   Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available).
 * 
 * Example
 * Input      Output     Comment
 * 3 3 6 1    12 1       3 3 6 1 → 6 6 1 → 12 1
 * 
 * Input          Output     Comment
 * 5 4 2 1 1 4    5 8 4      5 4 2 1 1 4 → 5 4 2 2 4 → 5 4 4 4 → 5 8 4
 * 
 * Input          Output     Comment
 * 8 2 2 4 8 16   16 8 16    8 2 2 4 8 16 → 8 4 4 8 16 → 8 8 8 16 → 16 8 16
 * 
 * Hints
 * 1.  Read the input and parse it to list of numbers.
 * 2.  Find the leftmost two adjacent equal cells.
 * 3.  Replace them with their sum.
 * 4.  Repeat (1) and (2) until no two equal adjacent cells survive.
 * 5.  Print the processed list of numbers.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToList();
            
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    input[i] = input[i] + input[i - 1];
                    input.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
