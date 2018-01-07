/* 
 * 02.   Add Two Numbers
 * 
 * Write a program, which reads 2 whole numbers and adds them together. Then, print them in the following format: 
 * -   “a + b = sum”
 * 
 * Example
 * Input    Output          Input    Output         Input    Output
 * 2        2 + 5 = 7       1        1 + 3 = 4      -3       -3 + 5 = 2
 * 5                        3                       5
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace AddTwoNumbers
{
    class MainClass
    {
        public static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}