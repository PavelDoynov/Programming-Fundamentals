/*
 * 04. Split by Word Casing
 * 
 * Read a text, split it into words and distribute them into 3 lists.
 * •   Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
 * •   Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
 * •   Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
 * 
 * Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
 * 
 * Print the 3 lists as shown in the example below.
 * 
 * Example
 * Input
 * Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.
 * 
 * Output
 * Lower-case: programming, at, databases, etc
 * Mixed-case: Learn, SoftUni, Java, 5, Web, C#
 * Upper-case: PHP, JS, HTML, CSS, SQL, AJAX
 * 
 * Hints
 * •   Split the input text using the above described separators.
 * •   Process the obtained list of words one by one.
 * •   Create 3 lists of words (initially empty): lowercase words, mixed-case words and uppercase words.
 * •   Check each word and append it to one of the above 3 lists:
 *   o   Count the lowercase letters and uppercase letters.
 *   o   If all letters are lowercase, append the word to the lowercase list.
 *   o   If all letters are uppercase, append the word to the uppercase list.
 *   o   Otherwise the word is considered mixed-case → append it to the mixed-case list.
 * •   Print the obtained 3 lists as shown in the example above.
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    class MainClass
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                                        .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', 
                '"', '\\', '\'', '/', ' ', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(char.IsUpper))
                {
                    upperCase.Add(input[i]);
                }
                else if (input[i].All(char.IsLower))
                {
                    lowerCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
