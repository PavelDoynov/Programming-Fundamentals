/*
 * 07. Sum Arrays
 * 
 * Write a program that reads two arrays of integers and sums them. When the arrays are not of the same size,
 * duplicate the smaller array a few times.
 * 
 * Example
 * Input       Output          Input       Output           Input       Output
 * 1 2 3 4     3 5 7 9         1 2 3 4 5   3 5 5 7 7        5 4 3       7 7 4 9
 * 2 3 4 5                     2 3                          2 3 1 4
 * 
 * Hints
 * •   Assume the first array arr1 has len1 elements and the second arr2 has len2 elements.
 * •   The result array will have max(len1, len2) elements.
 * •   We sum array elements one by one (from the first to the last).
 *     To enable rotating (take the first element as next after the last), we use the position % length indexing:
 *     arr1[i % len1] and arr2[i % len2].
*/



using System;
using System.Linq;

namespace Sum_Arrays
{
    class MainClass
    {
        public static void Main()
        {
            int[] arr1 = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] arr2 = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int[] sum = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i] }");
            }
        }
    }
}
