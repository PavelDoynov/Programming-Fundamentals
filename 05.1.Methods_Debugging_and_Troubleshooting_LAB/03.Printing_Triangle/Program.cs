/*
 * 03. Printing Triangle
 * 
 * Create a method for printing triangles as shown below:
 * 
 * Input:    Output:            Input:    Output:
 * 3         1                  4         1
 *           1 2                          1 2
 *           1 2 3                        1 2 3 
 *           1 2                          1 2 3 4
 *           1                            1 2 3
 *                                        1 2
 *                                        1
 * 
 * https://github.com/PavelDoynov
 */


using System;

namespace Printing_Triangle
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Pyramide(number);

        }

        public static void Pyramide (int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int p = 1; p <= i; p++)
                {
                    Console.Write("{0} ", p);
                }
                Console.WriteLine();
            }

            for (int i = number - 1; i >= 1; i--)
            {
                for (int p = 1; p <= i; p++)
                {
                    Console.Write("{0} ", p);
                }
                Console.WriteLine();
            }

        }
    }
}
