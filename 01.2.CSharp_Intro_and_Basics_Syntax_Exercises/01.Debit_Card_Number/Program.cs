/*
 * 01. Debit Card Number
 * 
 * Write a program, which receives 4 integers on the console and prints them in 4-digit debit card format.
 * See the examples below for the appropriate formatting.
 * 
 * Example
 * Input    Output                          Input    Output
 * 12       0012 0433 0001 5331             812      0812 0321 0123 0022
 * 433                                      321
 * 1                                        123
 * 5331                                     22
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace DebitCardNumber
{
    class MainClass
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");
        }
    }
}

// When you use "D4" formating: 1 -> 0001
//                             32 -> 0032