/*
 * 03. Fold and Sum 
 * 
 * Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower two rows 
 * (each holding 2 * k integers):
 * 
 * Example
 * Input          Output            Input               Output
 * 5 2 3 6        7 9               1 2 3 4 5 6 7 8     5 5 13 13
 * 
 * Input                          Output
 * 4 3 -1 2 5 0 1 9 8 6 7 -2      1 8 4 -1 16 14
 * 
 * Hints
 * •   Create the first row after folding: the first k numbers reversed, followed by the last k numbers reversed.
 * •   Create the second row after folding: the middle 2*k numbers.
 * •   Sum the first and the second rows.
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Fold_and_Sum
{
    class MainClass
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int splitArr = input.Length / 4;

            int[] firstQuarterArr = new int[splitArr];
            int[] middleArr = new int[splitArr * 2];
            int[] secondQuarterArr = new int[splitArr];

            firstQuarterArr = input.Take(splitArr).ToArray();
            middleArr = input.Skip(splitArr).Take(splitArr * 2).ToArray();
            secondQuarterArr = input.Skip(splitArr * 3).Take(splitArr).ToArray();

            Array.Reverse(firstQuarterArr);
            Array.Reverse(secondQuarterArr);

            int[] sum = new int[middleArr.Length];

            for (int i = 0; i < splitArr; i++)
            {
                sum[i] = firstQuarterArr[i] + middleArr[i];
                sum[splitArr + i] = secondQuarterArr[i] + middleArr[splitArr + i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}
