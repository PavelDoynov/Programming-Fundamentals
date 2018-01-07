/*
 * 09. Index of Letters
 * 
 * Write a program that creates an array containing all letters from the alphabet (a-z). 
 * Read a lowercase word from the console and print the index of each of its letters in the letters array.
 * 
 * Example
 * Input   Output         Input      Output
 * abcz    a -> 0         softuni    s -> 18
 *         b -> 1                    o -> 14
 *         c -> 2                    f -> 5
 *         z -> 25                   t -> 19
 *                                   u -> 20
 *                                   n -> 13
 *                                   i -> 8
 * 
 * https://github.com/PavelDoynov
*/


using System;

namespace Index_of_Letters
{
    class MainClass
    {
        public static void Main()
        {
            char[] letters = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write($"{letters[i]} -> {letters[i] - 97}");
                Console.WriteLine();
            }
        }
    }
}
