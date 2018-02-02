/*
 * 09. Multiply Evens by Odds
 * 
 * Create a program that reads an integer number and multiplies the sum of all its even digits by the sum of all its odd 
 * digits:
 * 
 * Example
 * Input:     Output:               Input:     Output:
 * 12345      54                    -12345     54
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Multiply_Evens_by_Odds
{
    class MainClass
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            int oddSum = OddNumberSum(number);
            int evenSum = EvenNumberSum(number);

            int result = oddSum * evenSum;
            Console.WriteLine($"{result}");
        }

        public static int OddNumberSum (string number)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    int currentNumber = int.Parse(number[i].ToString());
                    if (currentNumber % 2 != 0)
                    {
                        result += currentNumber;
                    }
                }
                catch (Exception)
                {

                }
            }
            return result;
        }

        public static int EvenNumberSum (string number)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                try
                {
                    int currentNumber = int.Parse(number[i].ToString());
                    if (currentNumber % 2 == 0)
                    {
                        result += currentNumber;
                    }
                }
                catch (Exception)
                {

                }
            }
            return result;
        }
    }
}
