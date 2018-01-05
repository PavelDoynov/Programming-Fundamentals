/*
 * 04. Fix Emails
 * 
 * You are given a sequence of strings, each on a new line, until you receive the “stop” command. 
 * The first string is the name of a person. On the second line, you will receive their email. 
 * Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive).
 * Print:
 * {name} – > {email} 
 * 
 * Example:
 * Input                        Output
 * Ivan                         Ivan -> ivanivan@abv.bg
 * ivanivan@abv.bg              Petar Ivanov -> petartudjarov@abv.bg
 * Petar Ivanov
 * petartudjarov@abv.bg
 * Mike Tyson
 * myke@gmail.us
 * stop
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    class MainClass
    {
        public static void Main()
        {
            Dictionary<string, string> namesAndMails = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                string mail = Console.ReadLine();
                string[] mailArr = mail.Split(new char[] { '.' });

                if (mailArr.Last() != "us" && mailArr.Last() != "uk")
                {
                    namesAndMails[input] = mail;
                }

                input = Console.ReadLine();
            }

            foreach (var item in namesAndMails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
