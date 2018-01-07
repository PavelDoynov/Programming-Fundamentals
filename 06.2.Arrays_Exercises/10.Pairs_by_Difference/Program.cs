/*
 * 10. Pairs of Difference
 * 
 * Write a program that count the number of pairs in given array which difference is equal to given number.
 * Input
 * •   The first line holds the sequence of numbers.
 * •   The second line holds the difference.
 * 
 * Example
 * Input         Output        Input            Output
 * 1 5 3 4 2     3             5 3 8 10 12 1    0
 * 2                           1
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class MainClass
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = i; k < input.Length; k++)
                {
                    if (input[i] + difference == input[k] || input[i] == input[k] + difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
