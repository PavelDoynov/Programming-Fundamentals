/*
 * 03. Sum, Min, Max, Average
 * 
 * Write a program to read n integers and print their sum, min, max, first, last and average values.
 * 
 * Hints:
 *   •   Include the “System.Linq” namespace to enable aggregate functions.
 *   •   Read the input array nums[].
 *   •   Use nums.Min(), nums.Max(), etc.
 * 
 * Input    Output
 * 5
 * 12        Sum = 72
 * 20        Min = -5
 * -5        Max = 37
 * 37        Average = 14.4
 * 8   
*/



using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Min_Max_Average
{
    class MainClass
    {
        public static void Main()
        {
            int numberOfIndex = int.Parse(Console.ReadLine());

            int[] numArr = new int[numberOfIndex];

            for (int i = 0; i < numberOfIndex; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                numArr[i] = currentNumber;
            }

            double averageNum = (double)numArr.Sum() / numberOfIndex;

            Console.WriteLine($"Sum = {numArr.Sum()}");
            Console.WriteLine($"Min = {numArr.Min()}");
            Console.WriteLine($"Max = {numArr.Max()}");
            Console.WriteLine($"Average = {averageNum}");
        }
    }
}
