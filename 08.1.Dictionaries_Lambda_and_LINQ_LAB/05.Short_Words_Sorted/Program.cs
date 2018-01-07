/*
 * 05. Short Words Sorted
 * 
 * Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, 
 * in lowercase.
 *   •   Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
 *   •   Use case-insensitive matching.
 *   •   Remove duplicated words.
 * 
 * Hints:
 *   •   To extract the words from the input text, split by the specified separators.
 *   •   Use a LINQ expression:
 *      o   Filter by word length: Where(…)
 *      o   Order by word: OrderBy(…)
 *      o   Use distinct to avoid repeated words: Distinct().
 * 
 * Input:
 * In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!
 * 
 * Output:
 * 2-3, and, c#, can, go, in, java, php, you
 * 
 * https://github.com/PavelDoynov
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    class MainClass
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                                    .ToLower()
                                    .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Distinct()
                                    .ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length < 5)
                {
                    result.Add(input[i]);
                }
            }

            result = result.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
