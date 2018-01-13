/*
 * 04. Longest Increasing Subsequence (LIS)
 * 
 * Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
 * 
 * Example
 * Input                Output          Input              Output          Input                              Output
 * 7 3 5 8 -1 0 6 7     3 5 6 7         1 2 5 3 5 2 4 1    1 2 3 5         0 10 20 30 30 40 1 50 2 3 4 5 6    0 1 2 3 4 5 6
 * 
 * Input                                     Output               Input                          Output
 * 11 12 13 3 14 4 15 5 6 7 8 7 16 9 8       3 4 5 6 7 8 16       3 14 5 12 15 7 8 9 11 10 1     3 5 7 8 9 11
 * 
 * Input   Output
 * 1       1
 * 
 * Hints
 * •   Assume we have n numbers in an array nums[0…n-1].
 * •   Let len[p] holds the length of the longest increasing subsequence (LIS) ending at position p.
 * •   In a for loop, we shall calculate len[p] for p = 0 … n-1 as follows:
 *   o   Let left is the leftmost position on the left of p (left < p), such that len[left] is the largest possible.
 *   o   Then, len[p] = 1 + len[left]. If left does not exist, len[p] = 1.
 *   o   Also, save prev[p] = left (we hold if prev[] the previous position, used to obtain the best length for position p).
 * •   Once the values for len[0…n-1] are calculated, restore the LIS starting from position p such that len[p] is 
 *       maximal and go back and back through p = prev[p].
 * •   The table below illustrates these computations:
 * 
 * index    0    1      2     3        4           5       6         7           8               9               10
 * nums[]   3    14     5     12       15          7       8         9           11              10              1
 * len[]    1    2      2     3        4           3       4         5           6               6               1
 * prev[]  -1    0      0     2        3           2       5         6           7               7              -1
 * LIS     {3}  {3,14} {3,5} {3,5,12} {3,5,12,15} {3,5,7} {3,5,7,8} {3,5,7,8,9} {3,5,7,8,9,11}  {3,5,7,8,9,10}  {1}
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence_LIS
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            int[] length = new int[input.Count];
            int[] previous = new int[input.Count];
            int maxLength = 0;
            int index = -1;

            for (int i = 0; i < input.Count; i++)
            {
                length[i] = 1;
                previous[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (input[k] < input[i] && length[k] + 1 > length[i])
                    {
                        length[i] = length[k] + 1;
                        previous[i] = k;
                    }
                }

                if (length[i] > maxLength)
                {
                    maxLength = length[i];
                    index = i;
                }
            }

            List<int> result = new List<int>();

            while (index != -1)
            {
                result.Add(input[index]);
                index = previous[index];
            }

            result.Reverse();

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}