/*
 * 05. Compare Char Arrays
 * 
 * Compare two char arrays lexicographically (letter by letter).
 * Print the them in alphabetical order, each on separate line.
 * 
 * Example
 * Input    Output      Input         Output       Input         Output        Input     Output
 * a b c    abc         p e t e r     annie        a n n i e     an            a b       ab
 * d e f    def         a n n i e     peter        a n           annie         a b       ab
 * 
 * Hints
 * •   Compare the first letter of arr1[] and arr2[], if equal, compare the next letter, etc.
 * •   If all letters are equal, the smaller array is the shorter.
 * •   If all letters are equal and the array lengths are the same, the arrays are equal.
 * 
 * https://github.com/PavelDoynov
*/



using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class MainClass
    {
        public static void Main()
        {
            char[] inputArr1 = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(char.Parse)
                                      .ToArray();
            
            char[] inputArr2 = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(char.Parse)
                                      .ToArray();
            
            int length = Math.Min(inputArr1.Length, inputArr2.Length);
            bool checker = false;

            for (int i = 0; i < length; i++)
            {
                if (inputArr2[i] > inputArr1[i])
                {
                    Console.WriteLine($"{string.Join("", inputArr1)}");
                    Console.WriteLine($"{string.Join("", inputArr2)}");
                    checker = true;
                    break;
                }
                else if (inputArr2[i] < inputArr1[i])
                {
                    Console.WriteLine($"{string.Join("", inputArr2)}");
                    Console.WriteLine($"{string.Join("", inputArr1)}");
                    checker = true;
                    break;
                }
            }

            if (checker == false)
            {
                if (inputArr1.Length != inputArr2.Length)
                {
                    if (inputArr1.Length < inputArr2.Length)
                    {
                        Console.WriteLine($"{string.Join("", inputArr1)}");
                        Console.WriteLine($"{string.Join("", inputArr2)}");
                    }
                    else
                    {
                        Console.WriteLine($"{string.Join("", inputArr2)}");
                        Console.WriteLine($"{string.Join("", inputArr1)}");
                    }
                }
                else
                {
                    Console.WriteLine($"{string.Join("", inputArr1)}");
                    Console.WriteLine($"{string.Join("", inputArr2)}");
                }
            }
        }
    }
}
