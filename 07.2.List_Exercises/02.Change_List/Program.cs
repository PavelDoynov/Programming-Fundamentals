/*
 * 2. Change List
 * 
 * Write a program, which reads a list of integers from the console and receives commands, which manipulate the list. 
 * Your program may receive the following commands: 
 * •   Delete {element} – delete all elements in the array, which are equal to the given element
 * •   Insert {element} {position} – insert element and the given position
 * 
 * You should stop the program when you receive the command Odd or Even. If you receive Odd ⇒ print all odd numbers in 
 * the array separated with single whitespace, otherwise print the even numbers.
 * 
 * Example
 * Input                 Output            Input                                Output
 * 1 2 3 4 5 5 5 6       1 3               20 12 4 319 21 31234 2 41 23 4       20 12 50 50 31234 2
 * Delete 5                                Insert 50 2
 * Insert 10 1                             Insert 50 5
 * Delete 5                                Delete 4
 * Odd                                     Even
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class MainClass
    {
        public static void Main()
        {
            List<int> inputNumbers = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            List<string> command = Console.ReadLine()
                                          .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int deleteNumber = int.Parse(command[1]);

                    for (int i = 0; i < inputNumbers.Count; i++)
                    {
                        if (inputNumbers[i] == deleteNumber)
                        {
                            inputNumbers.RemoveAt(i);
                            i = 0;
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int position = int.Parse(command[2]);
                    int insertNumber = int.Parse(command[1]);

                    inputNumbers.Insert(position, insertNumber);
                }

                command = Console.ReadLine()
                                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            }

            if (command[0] == "Odd")
            {
                for (int i = 0; i < inputNumbers.Count; i++)
                {
                    if (inputNumbers[i] % 2 != 0)
                    {
                        Console.Write($"{inputNumbers[i]} ");
                    }
                }
            }
            else if (command[0] == "Even")
            {
                for (int i = 0; i < inputNumbers.Count; i++)
                {
                    if (inputNumbers[i] % 2 == 0)
                    {
                        Console.Write($"{inputNumbers[i]} ");
                    }
                }
            }
        }
    }
}
