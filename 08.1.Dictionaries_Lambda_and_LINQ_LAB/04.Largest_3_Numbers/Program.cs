/*
 * 04. Largest 3 Numbers
 * 
 * Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.
 * 
 * Hints:
 * You can use LINQ query like this: nums.OrderByDescending(x => x).Take(3).
 * 
 * Input               Output
 * 10 30 15 20 50 5    50 30 20
 * 20 30               30 20
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest_3_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            var currentNums = input.OrderByDescending(x => x);
            
            int[] sortedNums = currentNums.Take(3).ToArray();

            Console.WriteLine(string.Join(" ", sortedNums));
        }
    }
}
