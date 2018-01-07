/* 
 * 01. Greeting
 * 
 * Write a program, which greets the user by their name, which it reads from the console.
 * 
 * Example
 * Input    Output               Input    Output               Input    Output
 * Pesho    Hello, Pesho!        Ivan     Hello, Ivan!         Merry    Hello, Merry!
 * 
 * https://github.com
*/


using System;

namespace Greeting
{
    class MainClass
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}