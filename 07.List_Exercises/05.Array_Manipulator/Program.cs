/*
 * 05. Array Manipulator
 * 
 * Write a program that reads an array of integers from the console and set of commands and executes them over the array. 
 * The commands are as follows:
 * 
 * •   add <index> <element> – adds element at the specified index (elements right from this position inclusively 
 *         are shifted to the right).
 * 
 * •   addMany <index> <element 1> <element 2> … <element n> – adds a set of elements at the specified index.
 * 
 * •   contains <element> – prints the index of the first occurrence of the specified element (if exists) in the array 
 *         or -1 if the element is not found.
 * 
 * •   remove <index> – removes the element at the specified index.
 * 
 * •   shift <positions> – shifts every element of the array the number of positions to the left (with rotation).
 *   o   For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
 * 
 * •   sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
 *   o   For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
 * 
 * •   print – stop receiving more commands and print the last state of the array.
 * 
 * Example
 * Input            Output                         Input                   Output
 * 1 2 4 5 6 7      0                              1 2 3 4 5               -1
 * add 1 8          -1                             addMany 5 9 8 7 6 5     [2, 3, 5, 9, 8, 7, 6, 5, 1]
 * contains 1       [1, 8, 2, 4, 5, 6, 7]          contains 15
 * contains -3                                     remove 3
 * print                                           shift 1
 *                                                 print
 * 
 * Input            Output                   Input                          Output 
 * 2 2 4 2 4        [6, 6, 6]                1 2 1 2 1 2 1 2 1 2 1 2        [-1, -2, -3, 6, 6, 6]
 * add 1 4                                   sumPairs
 * sumPairs                                  sumPairs
 * print                                     addMany 0 -1 -2 -3
 *                                           print
 * 
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class MainClass
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(long.Parse)
                                        .ToList();
             
            string input = Console.ReadLine();

            while (input != "print")
            {
                string[] inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .ToArray();
                string command = inputArr[0];

                if (command == "add") 
                {
                    int index = int.Parse(inputArr[1]);
                    long number = long.Parse(inputArr[2]);

                    numbers.Insert(index, number);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(inputArr[1]);
                    List<long> currentNumbers = inputArr.Skip(2).Select(long.Parse).ToList();
                    numbers.InsertRange(index, currentNumbers);
                }
                else if (command == "contains") 
                {
                    long number = long.Parse(inputArr[1]);

                    if (numbers.Contains(number)) 
                    {
                        for (int a = 0; a < numbers.Count; a++)
                        { 
                            if (numbers[a] == number)
                            { 
                                Console.WriteLine(a);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}", -1);
                    }
                }
                else if (command == "remove") 
                {
                    int index = int.Parse(inputArr[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    int shift = int.Parse(inputArr[1]);

                    for (int i = 0; i < shift; i++)
                    { 
                        long firstNumber = numbers[0];
                        for (int k = 0; k < numbers.Count - 1; k++)
                        {
                            numbers[k] = numbers[k + 1];
                        }

                        numbers[numbers.Count - 1] = firstNumber;
                    }
                }
                else if (command == "sumPairs")
                {
                    List<long> currentList = new List<long>();

                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        currentList.Add(numbers[i] + numbers[i + 1]);
                    }

                    if (numbers.Count % 2 != 0)
                    {
                        currentList.Add(numbers[numbers.Count - 1]);
                    }

                    numbers = currentList;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}
