/*
 * 06. Max Sequence of Equal Elements
 * 
 * Write a program that finds the longest sequence of equal elements in an array of integers. 
 * If several longest sequences exist, print the leftmost one.
 * 
 * Example
 * Input                     Output            Input         Output
 * 2 1 1 2 3 3 2 2 2 1       2 2 2             4 4 4 4       4 4 4 4
 * 
 * Input                     Output            Input                Output
 * 1 1 1 2 3 1 3 3           1 1 1             0 1 1 5 2 2 6 3 3    1 1
 * 
 * Hints
 * •   Start with the sequence that consists of the first element: start=0, len=1.
 * •   Scan the elements from left to right, starting at the second element: pos=1…n-1.
 *   o   At each step compare the current element with the element on the left.
 *     1.   Same value → you have found a sequence longer by one → len++.
 *     2.   Different value → start a new sequence from the current element: start=pos, len=1.
 *   o   After each step remember the sequence it is found to be longest at the moment: bestStart=start, bestLen=len.
 * •   Finally, print the longest sequence by using bestStart and bestLen.
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class MainClass
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int startIndex = 0;
            int start = 0;
            int countIndex = 0;
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    start = input[i];
                    count++;
                }
                else
                {
                    start = input[i];
                    count = 1;
                } 

                if (count > countIndex)
                {
                    countIndex = count;
                    startIndex = start;
                }
            }

            for (int i = 0; i < countIndex; i++)
            {
                Console.Write($"{startIndex} ");
            }
        }
    }
}
