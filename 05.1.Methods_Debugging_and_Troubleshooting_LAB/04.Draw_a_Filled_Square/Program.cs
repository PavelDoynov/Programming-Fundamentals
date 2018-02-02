/*
 * 04. Draw a Filled Square
 * 
 * Draw at the console a filled square of size n like in the example:
 * 
 * Input:     Output:
 * 4          --------
 *            -\/\/\/-
 *            -\/\/\/-
 *            --------
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Draw_a_Filled_Square
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine()); 

            HeaderFooter(number);
            Middle(number);
            HeaderFooter(number);
        }

        public static void HeaderFooter (int number)
        {
            Console.WriteLine("{0}", new string('-', number * 2));
        }

        public static void Middle (int number)
        {
            for (int i = 1; i < number - 1; i++)
            {
                Console.Write("-");
                for (int k = 0; k < number - 1; k++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
