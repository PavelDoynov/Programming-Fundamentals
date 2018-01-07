/*
 * 09. Extract Middle 1, 2 or 3 Elements
 * 
 * Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
 * •   n = 1 -> 1 element
 * •   even n -> 2 elements
 * •   odd n -> 3 elements
 * Create a program that reads an array of integers (space separated values) and prints the middle elements in the
 * format shown in the examples.
 * 
 * Example
 * Input            Output            Input         Output         Input   Output
 * 1 2 3 4 5 6 7    { 3, 4, 5 }       2 3 8 1 7 4   { 8, 1 }       5       { 5 }
 * 
 * Input                    Output
 * 10 20 30 40 50 60 70 80  { 40, 50 }
 * 
 * Hints
 * o   Write different logic for each case (n = 1, even n, odd n)
 * o   n = 1 → take the first element
 * o   odd n → take elements n/2-1, n/2, n/2+1
 * o   even n → take elements n/2-1 and n/2
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Linq;

namespace Extract_Middle_1_2_or_3_Elements
{
    class MainClass
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            if (inputArr.Length == 1)
            {
                Console.WriteLine($"{inputArr[0]}");
            }
            else
            {
                if (inputArr.Length % 2 == 0)
                {
                    int firstMiddleNum = inputArr[inputArr.Length / 2 - 1];
                    int secondMiddleNum = inputArr[inputArr.Length / 2];

                    Console.WriteLine($"{{{firstMiddleNum}, {secondMiddleNum}}}");
                }
                else if (inputArr.Length % 2 != 0)
                {
                    int firstMiddleNum = inputArr[inputArr.Length / 2 - 1];
                    int secondMiddleNum = inputArr[inputArr.Length / 2];
                    int thirdMiddleNum = inputArr[inputArr.Length / 2 + 1];

                    Console.WriteLine($"{{{firstMiddleNum}, {secondMiddleNum}, {thirdMiddleNum}}}");
                }
            }
        }
    }
}
