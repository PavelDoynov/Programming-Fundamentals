/*
 * 07. Max Sequence of Increasing Elements
 * 
 * Write a program that finds the longest increasing subsequence in an array of integers. The longest increasing 
 * subsequence is a portion of the array (subsequence) that is strongly increasing and has the longest possible length. 
 * If several such subsequences exist, find the left most of them.
 * 
 * Example
 * Input            Output        Input            Output
 * 3 2 3 4 2 2 4    2 3 4         4 5 1 2 3 4 5    1 2 3 4 5
 * 
 * Input            Output        Input            Output
 * 3 4 5 6          3 4 5 6       0 1 1 2 2 3 3    0 1
 * 
 * Hints
 * •   Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Max_Sequence_of_Increasing_Elements
{
    class MainClass
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            int number = 0;
            int finalNumber = 0;
            int count = 1;
            int finalCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - input[i - 1] >= 1)
                {
                    count++;

                    if (count > finalCount)
                    {
                        finalCount = count;
                        finalNumber = number;
                    }
                }
                else
                {
                    count = 1;
                    number = i;
                }
            }

            for (int i = finalNumber; i < finalCount + finalNumber; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
