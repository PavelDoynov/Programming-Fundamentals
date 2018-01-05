/*
 * 01. Phonebook
 * 
 * Write a program that receives some info from the console about people and their phone numbers. 
 * Each entry should have just one name and one number (both of them strings). 
 * 
 * On each line, you will receive some of the following commands:
 * •   A {name} {phone} – adds entry to the phonebook. 
 *     In case of trying to add a name that is already in the phonebook you should change the existing phone number
 *     with the new one provided.
 * •   S {name} – searches for a contact by given name and prints it in format "{name} -> {number}".
 *     In case the contact isn't found, print "Contact {name} does not exist.".
 * •   END – stop receiving more commands.
 * 
 * Example:
 * Input                           Output
 * A Nakov +359888001122           Simo -> 02/987665544
 * A RoYaL(Ivan) 666               Contact simo does not exist.
 * A Gero 5559393                  Contact RoYaL does not exist.
 * A Simo 02/987665544             RoYaL(Ivan) -> 666
 * S Simo
 * S simo
 * S RoYaL
 * S RoYaL(Ivan)
 * END
*/



using System;
using System.Collections.Generic;
using System.Linq;


namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] command = Console.ReadLine()
                                      .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
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

                command = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
            }
        }
    }
}