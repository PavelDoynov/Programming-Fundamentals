/*
 * 08. Most Frequent Number
 * 
 * Write a program that finds the most frequent number in a given sequence of numbers. 
 * •   Numbers will be in the range [0…65535].
 * •   In case of multiple numbers with the same maximal frequency, print the left most of them.
 * 
 * Example
 * Input                        Output              Input               Output
 * 4 1 1 4 2 3 4 4 1 2 4 9 3    4                   2 2 2 2 1 2 2 2     2
 * 
 * Input                        Output
 * 7 7 7 0 2 2 2 0 10 10 10     7
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class MainClass
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int count = 0;
            int finalCout = 0;
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = i; k < input.Length; k++)
                {
                    if (input[i] == input[k])
                    {
                        count++;

                        if (count > finalCout)
                        {
                            finalCout = count;
                            number = input[i];
                        }
                    }
                }

                count = 0;
            }

            Console.WriteLine("{0}", number);
        }
    }
}
