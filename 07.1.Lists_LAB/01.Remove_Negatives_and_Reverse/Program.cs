/*
 * 01. Remove Negatives and Reverse
 * 
 * Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
 * In case of no elements left in the list, print “empty”.
 * 
 * Example
 * Input              Output             Input           Output          Input         Output
 * 10 -5 7 9 -33 50   50 9 7 10          7 -2 -10 1      1 7             -1 -2 -3      empty
 * 
 * Hints
 * •   Read a text line from the console, split it by space, parse the obtained items as integers 
 *        and convert them to list of integers.
 * •   Create a new empty list for the results.
 * •   Scan the input list from the end to the beginning. Check each element and append all non-negative 
 *        elements to the result list.
 * •   Finally, print the results list (at a single line holding space-separated numbers).
 * 
 * 
 * https://github.com/PavelDoynov
*/

 
using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse 
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    i = 0;
                }
            }

            if (input[0] < 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();

                for (int i = 0; i < input.Count; i++)
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
