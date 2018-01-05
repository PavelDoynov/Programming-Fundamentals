/*
 * 02. Odd Occurrences
 * 
 * Write a program that extracts from a given sequence of words all elements that present in 
 * it odd number of times (case-insensitive).
 *   •   Words are given in a single line, space separated.
 *   •   Print the result elements in lowercase, in their order of appearance.
 * 
 * Input                                    Output
 * Java C# PHP PHP JAVA C java              java, c#, c
 * 3 5 5 hi pi HO Hi 5 ho 3 hi pi           5, hi
 * a a A SQL xx a xx a A a XX c             a, sql, xx, c
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class MainClass
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                                        .ToLower()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            Dictionary<string, int> inputCount = new Dictionary<string, int>();

            for (int i = 0; i < input.Count; i++)
            {
                string currentInput = input[i];

                if (!inputCount.ContainsKey(currentInput))
                {
                    inputCount[currentInput] = 1;
                }
                else
                {
                    inputCount[currentInput] += 1;
                }
            }

            List<string> resultOddInput = new List<string>();

            foreach (var item in inputCount)
            {
                if (item.Value % 2 != 0)
                {
                    resultOddInput.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultOddInput));
        }
    }
}
