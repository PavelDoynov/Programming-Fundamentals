/*
 * 05. Rounding Numbers Away from Zero
 * 
 * Write a program to read an array of real numbers (space separated values), round them to the nearest integer in
 * “away from 0” style and print the output as in the examples below.
 * 
 * Rounding in “away from zero” style means:
 * •   To round to the nearest integer, e.g. 2.9 → 3; -1.75 → -2
 * •   In case the number is exactly in the middle of two integers (midpoint value), 
 *     round it to the next integer which is away from the 0.
 * 
 * Example
 * Input                     Output            Input                           Output
 * 0.9 1.5 2.4 2.5 3.14      0.9 => 1          -5.01 -1.599 -2.5 -1.50 0       -5.01 => -5
 *                           1.5 => 2                                          -1.599 => -2
 *                           2.4 => 2                                          -2.5 => -3
 *                           2.5 => 3                                          -1.50 => -2
 *                           3.14 => 3                                         0 => 0
 * 
 * Hints:
 * •   Approach I: Take the absolute value of each input number, add 0.5 and truncate the integral part. 
 *     If the original number is negative, make the result also negative.
 * •   Approach II: Search in Internet for “rounding away from zero” + C#. 
 *     You should find a built-in C# method for rounding in many styles. Choose the “away from zero” rounding.
 */


using System;
using System.Linq;

namespace Rounding_Numbers_Away_from_Zero
{
    class MainClass
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(double.Parse)
                                   .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => { Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
