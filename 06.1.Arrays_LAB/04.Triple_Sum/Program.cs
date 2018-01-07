/*
 * 04. Triple Sum
 * 
 * Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c 
 * (where a stays to the left from b). Print “No” if no such triples exist.
 * 
 * Example
 * Input          Output
 * 1 1 1 1        No
 * 
 * Input          Output
 * 3 1 5 6 1 2    3 + 2 == 5
 *                1 + 5 == 6
 *                1 + 1 == 2
 *                1 + 2 == 3
 *                5 + 1 == 6
 *                1 + 2 == 3
 * 
 * Hints:
 * •   Read the input numbers in array arr[].
 * •   Use nested loops to generate all pairs {a, b}, such that 0 ≤ a < b < n.
 * •   Check whether arr[] contains the sum arr[a] + arr[b].
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Triple_Sum
{
    class MainClass
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            bool checker = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                int numA = numbers[a];

                for (int b =  a + 1; b < numbers.Length; b++)
                {
                    int numB = numbers[b];

                    int sum = numA + numB;

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", numA, numB, sum);
                        checker = true;
                    }
                }
            }

            if (checker == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
