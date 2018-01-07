/*
 * 04. Sieve of Eratosthenes
 * 
 * Write a program to find all prime numbers in range [1…n]. Implement the algorithm called 
 * “Sieve of Eratosthenes”: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes. 
 * Steps in the “Sieve of Eratosthenes” algorithm:
 * 
 * 1.  Assign primes[0…n] = true
 * 2.  Assign primes[0] = primes[1] = false
 * 3.  Find the smallest p, which holds primes[p] = true
 *   •   Print p (it is prime)
 *   •   Assign primes[2*p] = primes[3*p] = primes[4*p] = … = false
 * 4.  Repeat for the next smallest p < n.
 * 
 * Example
 * Input      Output           Input     Output
 * 6          2 3 5            25        2 3 5 7 11 13 17 19 23
 * 
 * https://github.com/PavelDoynov
*/


using System;

namespace Sieve_of_Eratosthenes
{
    class MainClass
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool[] arrayTrue = new bool[number + 1];

            for (int i = 2; i < arrayTrue.Length; i++)
            {
                arrayTrue[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(number); i++)
            {

                if (arrayTrue[i] == true)
                {
                    for (int a = (i * i); a < arrayTrue.Length; a += i)
                    {
                        arrayTrue[a] = false;
                    } 
                }
            }

            for (int i = 2; i <= number; i++)
            {
                if (arrayTrue[i] == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
