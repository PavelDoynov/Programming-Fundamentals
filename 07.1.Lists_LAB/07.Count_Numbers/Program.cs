/*
 * 07. Count Numbers
 * 
 * Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.
 * 
 * Example
 * Input                Output               Input                Output
 * 8 2 2 8 2 2 3 7      2 -> 4               10 8 8 10 10         8 -> 2
 *                      3 -> 1                                    10 -> 3
 *                      7 -> 1
 *                      8 -> 2
 * 
 * Hints
 * Several algorithms can solve this problem:
 * •   Use an array count[0…1000] to count in counts[x] the occurrences of each element x.
 * •   Sort the numbers and count occurrences of each number.
 * •   Use a dictionary counts<int, int> to count in counts[x] the occurrences of each element x.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            SortedDictionary<int, int> resultInput = new SortedDictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (!resultInput.ContainsKey(input[i]))
                {
                    resultInput[input[i]] = 1;
                }
                else
                {
                    resultInput[input[i]] += 1;
                }
            }

            foreach (var number in resultInput)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
