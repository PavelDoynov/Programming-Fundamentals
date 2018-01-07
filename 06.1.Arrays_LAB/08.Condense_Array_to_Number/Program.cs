/*
 * 08. Condense Array to Number
 * 
 * Write a program to read an array of integers and condense them by summing adjacent couples of elements until 
 * a single integer is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second 
 * two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.
 * 
 * Еxample
 * Input         Output
 * 2 10 3        25
 * 
 * Input         Output
 * 5 0 4 1 2     35
 * 
 * Input         Output
 * 1             1
 * 
 * Hints
 * While we have more than one element in the array nums[], repeat the following:
 * •   Allocate a new array condensed[] of size nums.Length-1.
 * •   Sum the numbers from nums[] to condensed[]:
 *   o   condensed[i] = nums[i] + nums[i+1]
 * •   nums[] = condensed[]
 * 
 * https://github.com/PavelDoynov
*/



using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class MainClass
    {
        public static void Main()
        {
            int[] numberArr = Console.ReadLine()
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            while (numberArr.Length != 1)
            {
                int[] currentNumArr = new int[numberArr.Length - 1];

                for (int i = 0; i < numberArr.Length - 1; i++)
                {
                    int sum = numberArr[i] + numberArr[i + 1];

                    currentNumArr[i] = sum;
                }

                numberArr = currentNumArr;
            }

            Console.WriteLine($"{numberArr[0]}");
        }
    }
}
