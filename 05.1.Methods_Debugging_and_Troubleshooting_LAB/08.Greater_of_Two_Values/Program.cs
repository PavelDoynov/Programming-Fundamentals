/*
 * 08. Greater of Two Values
 * 
 * You are given two values of the same type as input. The values can be of type int, char of string. 
 * Create a method GetMax() that returns the greater of the two values: 
 * 
 * Example
 * Input:    Output:         Input:    Output:          Input:    Output:
 * int       16              char      z                string    Todor
 * 2                         a                          Ivan
 * 16                        z                          Todor
 * 
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Greater_of_Two_Values
{
    class MainClass
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int numberA = int.Parse(Console.ReadLine());
                int numberB = int.Parse(Console.ReadLine());

                int maxNumber = MaxNumber(numberA, numberB);
                Console.WriteLine(maxNumber);
            }
            else if (command == "char")
            {
                char charA = char.Parse(Console.ReadLine());
                char charB = char.Parse(Console.ReadLine());

                Console.WriteLine(MaxChar(charA, charB));
            }
            else if (command == "string")
            {
                string wordA = Console.ReadLine();
                string wordB = Console.ReadLine();

                Console.WriteLine(MaxString(wordA, wordB));
            }
        }

        public static int MaxNumber (int numA, int numB)
        {
            if (numA > numB)
            {
                return numA;
            }

            return numB;
        }

        public static char MaxChar (char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }

            return secondChar;
        }

        public static string MaxString (string wordA, string wordB)
        {
            
            if (wordA.CompareTo(wordB) >= 0)
            {
                return wordA;
            }

            return wordB;
        }
    }
}
