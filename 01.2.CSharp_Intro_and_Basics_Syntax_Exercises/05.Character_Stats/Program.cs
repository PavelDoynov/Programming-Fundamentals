/* 
 * 05. Character Stats
 * 
 * Write a program, which displays information about a video game character. 
 * You will receive their name, current health, maximum health, current energy and maximum energy on separate lines. 
 * The current values will always be valid (equal or lower than their respective max values). Print them in the format 
 * as per the examples.
 * 
 * Example
 * Input      Output                        Input      Output
 * Mayro      Name: Mayro                   Bauser     Name: Bauser
 * 5          Health: ||||||.....|          10         Health: ||||||||||||
 * 10         Energy: ||||||||||.|          10         Energy: ||||||||||||
 * 9                                        10
 * 10                                       10
 * 
 * Input      Output                             Input      Output
 * Loogi      Name: Loogi                        Toad       Name: Toad
 * 8          Health: |||||||||............|     0          Health: |.....|
 * 20         Energy: |||............|           5          Energy: |..........|
 * 2                                             0
 * 14                                            10
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace CharacterStats
{
    class MainClass
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHealth - currentHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
        }
    }
}