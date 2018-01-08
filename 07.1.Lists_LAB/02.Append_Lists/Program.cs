/*
 * 02. Append Lists
 * 
 * Write a program to append several lists of numbers.
 * •   Lists are separated by ‘|’.
 * •   Values are separated by spaces (‘ ’, one or several)
 * •   Order the lists from the last to the first, and their values from left to right.
 * 
 * Example
 * Input                      Output
 * 1 2 3 |4 5 6 |  7  8       7 8 4 5 6 1 2 3
 * 
 * Input                      Output
 * 7 | 4  5|1 0| 2 5 |3       3 2 5 1 0 4 5 7
 * 
 * Input                      Output
 * 1| 4 5 6 7  |  8 9         8 9 4 5 6 7 1
 * 
 * Hints
 * •   Create a new empty list for the results.
 * •   Split the input by ‘|’ into array of tokens.
 * •   Pass through each of the obtained tokens from tight to left.
 *   o   For each token, split it by space and append all non-empty tokens to the results.
 * •   Print the results.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    class MainClass
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                                     .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                                     .ToList();

            input.Reverse();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Count(); i++)
            {
                int[] currentToken = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(int.Parse)
                                             .ToArray();

                for (int tokenIndex = 0; tokenIndex < currentToken.Length; tokenIndex++)
                {
                    result.Add(currentToken[tokenIndex]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
