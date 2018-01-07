/*
 * 02. Reverse an Array of Integers
 * 
 * Write a program to read an array of integers, reverse it and print its elements. The input consists of a 
 * number n (the number of elements) + n integers, each as a separate line. 
 * Print the output on a single line (space separated).
 * 
 * Example
 * Input     Output
 * 3
 * 10        30 20 10
 * 20
 * 30  
 * 
 * Input     Output
 * 4
 * -1        5 99 20 -1
 * 20
 * 99
 * 5  
 * 
 * Hints
 * •   First, read the number n.
 * •   Allocate an array of n integers.
 * •   Read the integers in a for-loop.
 * •   Instead of reversing the array, you can just pass through the elements from the last (n-1) to the 
 *     first (0) with a reverse for-loop.
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Reverse_an_Array_of_Integers
{
    class MainClass
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int[] arrayNumber = new int[input];

            for (int i = 0; i < input; i++)
            {
                arrayNumber[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrayNumber.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arrayNumber[i]} ");
            }
        }
    }
}
