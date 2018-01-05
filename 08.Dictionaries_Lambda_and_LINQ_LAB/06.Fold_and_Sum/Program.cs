/*
 * 06. Fold and Sum
 * 
 * Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower rows (2*k integers):
 * 
 * Input                              Output             Comments
 * 5 2 3 6 . . . . . . . . . . . . .  7 9 . . . . . . .  5  6 + 2  3 = 7  9
 * 1 2 3 4 5 6 7 8 . . . . . . . . .  5 5 13 13 . . . .  2  1  8  7 + 3  4  5  6 = 5  5 13 13
 * 4 3 -1 2 5 0 1 9 8 6 7 -2 . . . .  1 8 4 -1 16 14  . -1  3  4 -2  7  6 + 2  5  0  1  9  8 = 1  8  4 -1 16 14
 * 
 * Hints:
 * Use a LINQ expression:
 *   •   Row 1, left part: take the first k numbers and reverse.
 *   •   Row 1, right part: reverse and take the first k numbers.
 *   •   Concatenate the left and the right part of row 1.
 *   •   Row 2: skip the first k numbers and take the next 2*k numbers.
 *   •   Sum the arrays row1 and row2: var sum = row1.Select((x, index) => x + row2[index]).
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace Fold_and_Sum
{
    class MainClass
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int arrIndex = numbers.Length / 4;

            int[] firstQuarter = numbers.Take(arrIndex).ToArray();
            firstQuarter =  firstQuarter.Reverse().ToArray();

            int[] middlePart = numbers.Skip(arrIndex).Take(arrIndex * 2).ToArray();

            int[] lastQuarter = numbers.Skip(arrIndex * 3).Take(arrIndex).ToArray();
            lastQuarter = lastQuarter.Reverse().ToArray();

            int[] newArr = firstQuarter.Concat(lastQuarter).ToArray();

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = newArr[i] + middlePart[i];
            }

            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
