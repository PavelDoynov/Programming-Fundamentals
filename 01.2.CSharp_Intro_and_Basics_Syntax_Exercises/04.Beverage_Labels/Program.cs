/*
 * 04. Beverage Labels
 * 
 * Write a program, which reads a food product name, volume, energy content per 100ml and sugar content per 100ml. 
 * Calculate the energy and sugar content for the given volume and print them on the console in the following format:
 * •   Name – as per the input
 * •   Volume – integer, suffixed by “ml” (e.g. “220ml”)
 * •   Energy content – integer, suffixed by “kcal” (e.g. “500kcal”)
 * •   Sugar content – integer, suffixed by “g” (e.g. “30g”) 
 * 
 * Example
 * Input           Output                          Input                    Output
 * Nuka-Cola       220ml Nuka-Cola:                Nuka-Cola Quantum        350ml Nuka-Cola Quantum:
 * 220             660kcal, 154g sugars            350                      2100kcal, 490g sugars
 * 300                                             600
 * 70                                              140
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace BeverageLabels
{
    class MainClass
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100 = double.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());

            double energyContent = (volume / 100) * energyPer100;
            double sugarContent = (volume / 100) * sugarPer100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}