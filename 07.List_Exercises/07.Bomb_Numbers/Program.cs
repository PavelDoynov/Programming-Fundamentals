/*
 * 07. Bomb Numbers
 * 
 * Write a program that reads sequence of numbers and special bomb number with a certain power. 
 * Your task is to detonate every occurrence of the special bomb number and according to its power his neighbors 
 * from left and right. Detonations are performed from left to right and all detonated numbers disappear. 
 * Finally print the sum of the remaining elements in the sequence.
 * 
 * Example
 * Input                Output         Comments
 * 1 2 2 4 2 2 2 9      12             Special number is 4 with power 2. After detontaion we left with the sequence 
 * 4 2                                 [1, 2, 9] with sum 12.
 * 
 * Input                Output         Comments
 * 1 4 4 2 8 9 1        5              Special number is 9 with power 3. After detontaion we left with the sequence 
 * 9 3                                 [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just 
 *                                     it (one number instead of 3).
 * 
 * Input                Output         Comments
 * 1 7 7 1 2 3          6              Detonations are performed from left to right. We could not detonate the second 
 * 7 1                                 occurance of 7 because its already destroyed by the first occurance. 
 *                                     The numbers [1, 2, 3] survive. Their sum is 6.
 * 
 * Input                    Output     Comments
 * 1 1 2 1 1 1 2 1 1 1      4          The red and yellow numbers disappear in two sequential detonations. 
 * 2 1                                 The result is the sequence [1, 1, 1, 1]. Sum = 4.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class MainClass
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            List<int> bombAndRange = Console.ReadLine()
                                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();

            int bombNumber = bombAndRange[0];
            int bombRange = bombAndRange[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (bombNumber == numbers[i])
                {
                    int leftSide = Math.Max(i - bombRange, 0);
                    int rightSide = Math.Min(i + bombRange, numbers.Count - 1);

                    numbers.RemoveRange(i, rightSide - i);
                    numbers.RemoveAt(i);
                    numbers.RemoveRange(leftSide, i - leftSide);


                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}


