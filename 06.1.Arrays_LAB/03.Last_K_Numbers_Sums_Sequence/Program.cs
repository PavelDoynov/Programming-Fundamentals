/*
 * 03. Last K Numbers Sums Sequence
 * 
 * Enter two integers n and k. Generate and print the following sequence of n elements:
 * •   The first element is: 1
 * •   All other elements = sum of the previous k elements (if less than k are available, sum all of them)
 * •   Example: n = 9, k = 5 → 120 = 4 + 8 + 16 + 31 + 61
 * 
 * Example
 * Input     Output              Input     Output                 Input     Output            
 * 6         1 1 2 4 7 13        8         1 1 2 3 5 8 13 21      9         1 1 2 4 8 16 31 61 120
 * 3                             2                                5
 * 
 * Hints
 * •   Use an array of integers to hold the sequence.
 * •   Initially seq[0] = 1
 * •   Use two nested loops:
 *    o   Loop through all elements i = 1 … n 
 *    o   Sum the elements i-k … i-1: seq[i] = sum(seq[i-k … i-1])
 * 
 * https://github.com/PavelDoynov
*/


using System;

namespace Last_K_Numbers_Sums_Sequence
{
    class MainClass
    {
        public static void Main()
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int keyIndex = int.Parse(Console.ReadLine());

            long[] arr = new long[arrLenght];
            arr[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {

                for (int j = i - 1; j >= Math.Max(0, i - keyIndex); j--)
                {
                    arr[i] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
