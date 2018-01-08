/*
 * 06. Square Numbers
 * 
 * Read a list of integers and extract all square numbers from it and print them in descending order. 
 * A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.
 * 
 * Example
 * Input             Output            Input                     Output
 * 3 16 4 5 6 8 9    16 9 4            12 1 9 4 16 8 25 49 16    49 25 16 16 9 4 1
 * 
 * Hints
 * •   To find out whether an integer is “square number”, check whether its square root is integer 
 *      number (has no fractional part):
 *   o   if (√num == (int)√num) …
 * •   To order the results list in descending order use sorting by lambda function:
 *   o   squareNums.Sort((a, b) => b.CompareTo(a));
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            List<int> resultInput = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)Math.Sqrt(input[i]))
                {
                    resultInput.Add(input[i]);
                }
            }

            resultInput.Sort((a, b) => b.CompareTo(a));

            foreach (var item in resultInput)
            {
                Console.Write($"{item} ");
            }
        }
    }
}

/* Other way to sort the "resultInput" is:
 * 
 *    resultInput.Sort();
 *    resultInput.Reverse();
*/