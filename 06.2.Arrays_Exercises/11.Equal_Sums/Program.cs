/*
 * 11. Equal Sums
 * 
 * Write a program that determines if there exists an element in the array such that the sum of the elements on its 
 * left is equal to the sum of the elements on its right. If there are no elements to the left / right, their sum is 
 * considered to be 0. Print the index that satisfies the required condition or “no” if there is no such index.
 * 
 * Example
 * Input     Output      Input    Output      Input    Output      Input    Output
 * 1 2 3 3   2           1 2      no          1        0           1 2 3    no
 * 
 * Input                          Output
 * 10 5 5 99 3 4 2 5 1 1 4        3
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Equal_Sums
{
    class MainClass
    {
        public static void Main()
        {
            int[] intput = Console.ReadLine()
                                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            bool equalSums = false;

            for (int i = 0; i < intput.Length; i++)
            {
                int[] firstArr = intput.Take(i).ToArray();
                int[] secondArr = intput.Skip(i + 1).ToArray();

                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine($"{i}");
                    equalSums = true;
                    break;
                }
            }

            if (equalSums == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
