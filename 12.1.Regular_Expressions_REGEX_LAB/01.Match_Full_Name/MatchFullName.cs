/*
 * 01. Match Full Name
 * 
 * Write a C# Program to match full names from a list of names and print them on the console.
 * 
 * Example
 * Input:
 * Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan    Ivanov
 * 
 * Output:
 * Ivan Ivanov Test Testov
 * 
 * https://github.com/PavelDoynov
 */


using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            Regex regex = new Regex(pattern);
            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match name in match)
            {
                result.Add(name.ToString());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
