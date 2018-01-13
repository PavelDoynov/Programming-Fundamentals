/*
 * 03. Search for a Number
 * 
 * On the first line, you will receive a list of integers. On the next line, you will receive an array with exactly 
 * three numbers. 
 * First number represents the number of elements you have to take from the list (starting from the first one).
 * Second number represents the number of elements you have to delete from the numbers you 
 * took (starting from the first one). 
 * Last number is the number we search in our collection after the manipulations. 
 * If it is present print: “YES!”, otherwise print “NO!”
 * 
 * Example
 * Input            Output           Input                            Output
 * 1 2 3 4 5 6      YES!             12 412 123 21 654 34 65 3 23     NO!
 * 5 2 3                             7 4 21
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class MainClass
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            int[] changingArr = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i == changingArr[0])
                {
                    break;
                }
                result.Add(input[i]);
            }

            for (int i = changingArr[1] - 1; i >= 0; i--)
            {
                result.RemoveAt(i);
            }

            if (result.Contains(changingArr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

