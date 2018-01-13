/*
 * 06. Sum Reversed Numbers
 * 
 * Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
 * 
 * Example
 * Input           Output       Comments
 * 123 234 12      774          321 + 432 + 21 = 774
 * 
 * Input                Output       Comments
 * 12 12 34 84 66 12    220          21 + 21 + 43+ 48 + 66 + 21 = 220
 * 
 * Input            Output       Comments
 * 120 1200 12000   63           21 + 21 + 21 = 63
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                char[] currentToken = input[i].ToCharArray();
                string currentTokenReverce = null;

                for (int k = currentToken.Length - 1; k >= 0; k--)
                {
                    currentTokenReverce += currentToken[k];
                }

                result.Add(int.Parse(currentTokenReverce));
            }

            Console.WriteLine($"{result.Sum()}");
        }
    }
}
