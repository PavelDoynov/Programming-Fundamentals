/*
 * 06. Reverse an Array of Strings
 * 
 * Write a program to read an array of strings, reverse it and print its elements. 
 * The input consists of a sequence of space separated strings. Print the output on a single line (space separated).
 * 
 * Example
 * Input          Output
 * a b c d e      e d c b a
 * -1 hi ho w     w ho hi -1
 * 
 * Hints
 * •   Read the array of strings.
 * •   Exchange the first element (at index 0) with the last element (at index n-1).
 * •   Exchange the second element (at index 1) with the element before the last (at index n-2).
 * •   Continue the same way until the middle of the array is reached.
 * •   Another, shorter approach, is to use the .Reverse() extension method from “System.Linq”.
*/


using System;
using System.Linq;

namespace Reverse_an_Array_of_Strings
{
    class MainClass
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
