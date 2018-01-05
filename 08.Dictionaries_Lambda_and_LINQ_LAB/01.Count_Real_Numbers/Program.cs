/*
 * 01. Count Real Numbers
 * 
 * Read a list of real numbers and print them in ascending order along with their number of occurrences.
 * 
 * Hints:
 * •   Use SortedDictionary<double, int> named counts.
 * •   Pass through each input number num and increase counts[num] (when num exists in the dictionary) 
 *     or assign counts[num] = 1 (when num does not exist in the dictionary).
 * •   Pass through all numbers num in the dictionary (counts.Keys) and print the number num and 
 *     its count of occurrences counts[num].
 * 
 * Example:
 * Input                  Output
 * 8 2.5 2.5 8 2.5        2.5 -> 3
 *                        8 -> 2
*/



using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Real_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                                          .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(double.Parse)
                                          .ToList();

            SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count(); i++)
            {
                double currentNumber = numbers[i];

                if (!countNumbers.ContainsKey(currentNumber))
                {
                    countNumbers[currentNumber] = 1;
                }
                else
                {
                    countNumbers[currentNumber] += 1;
                }
            }

            foreach (var item in countNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
