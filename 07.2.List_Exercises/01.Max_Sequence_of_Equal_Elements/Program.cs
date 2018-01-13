/*
 * 01. Max Sequence of Equal Elements
 * 
 * Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.
 * 
 * Example
 * Input              Output       Input              Output      Input      Output
 * 3 4 4 5 5 5 2 2    5 5 5        7 7 4 4 5 5 3 3    7 7         1 2 3 3    3 3
 * 
 * Hints
 * •   Scan positions p from left to right and keep the start and length of the current sequence 
 *      of equal numbers ending at p.
 * •   Keep also the currently best (longest) sequence (bestStart + bestLength) and update it after each step.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            int currentCount = 1;
            int finalCount = 0;
            int finalNumber = 0;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > finalCount)
                {
                    finalCount = currentCount;
                    finalNumber = input[i - 1];
                }
            }

            for (int i = 0; i < finalCount; i++)
            {
                Console.Write($"{finalNumber} ");
            }
        }
    }
}
