/*
 * 02. Rotate and Sum
 * 
 * To “rotate an array on the right” means to move its last element first: {1, 2, 3} → {3, 1, 2}.
 * Write a program to read an array of n integers (space separated on a single line) and an integer k, 
 * rotate the array right k times and sum the obtained arrays after each rotation as shown below.
 * 
 * Example
 * Input          Output              Input        Output
 * 3 2 4 -1       3 2 5 6             1 2 3 4 5    12 10 8 6 9
 * 2                                  3
 * 
 * Hints
 * •   After r rotations the element at position i goes to position (i + r) % n.
 * •   The sum[] array can be calculated by two nested loops: for r = 1 … k; for i = 0 … n-1.
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class MainClass
    {
        public static void Main()
        {
            int[] numArr = Console.ReadLine()
                                  .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();
            int rotate = int.Parse(Console.ReadLine());

            int[] sumNumArr = new int[numArr.Length];   

            for (int i = 0; i < rotate; i++)
            {
                int lastElement = numArr[numArr.Length - 1]; 

                for (int e = numArr.Length - 1; e > 0; e--)  
                {
                    numArr[e] = numArr[e - 1];
                }

                numArr[0] = lastElement;  

                for (int w = 0; w < numArr.Length; w++)
                {
                    sumNumArr[w] += numArr[w]; 
                }
            }
            Console.WriteLine(string.Join(" ", sumNumArr));
        }
    }
}
