/*
 * 02. Phonebook Upgrade
 * 
 * Add functionality to the phonebook from the previous task to print all contacts ordered 
 * lexicographically when receive the command “ListAll”.
 * 
 * Example:
 * Input                            Output
 * A Nakov +359888001122            Gero -> 5559393
 * A RoYaL(Ivan) 666                Nakov -> +359888001122
 * A Gero 5559393                   RoYaL(Ivan) -> 666
 * A Simo 02/987665544              Simo -> 02/987665544
 * ListAll
 * END
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook_Upgrade
{
    class MainClass
    {
        public static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string[] command = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                }
                if (command[0] == "S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]} ");

                    }
                    else
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");

                    }
                }
                if (command[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                command = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            }
        }
    }
}
