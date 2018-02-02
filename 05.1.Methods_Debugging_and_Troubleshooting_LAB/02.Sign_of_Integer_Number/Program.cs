/*
 * 02. Sign of Integer Number
 * 
 * Create a method that prints the sign of an integer number n.
 * 
 * Input:       Output:
 * 2            The number 2 is positive.
 * 
 * Input:       Output:
 * -5           The number -5 is negative.
 * 
 * Input:       Output:
 * 0            The number 0 is zero.
 * 
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Sign_of_Integer_Number
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            NumberChecker(number);
        }

        public static void NumberChecker (int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
