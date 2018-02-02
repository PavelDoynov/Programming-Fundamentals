/*
 * 07. Math Power
 * 
 * Create a method that calculates and returns the value of a number raised to a given power:
 * 
 * Example
 * Input:     Output:           Input:     Output:
 * 2          256               3          81
 * 8                            4
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Math_Power
{
    class MainClass
    {
        public static void Main()
        {

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = MathPower(number, power);

            Console.WriteLine(result);
        }

        public static double MathPower (double number, int power)
        {
            //double result = Math.Pow(number, power);

            double result = number;

            for (int i = 1; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
