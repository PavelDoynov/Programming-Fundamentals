/*
 * 03. A Miner Task
 * 
 * You are given a sequence of strings, each on a new line. Every odd line on the console is 
 * representing a resource (e.g. Gold, Silver, Copper, and so on), and every even – quantity. 
 * Your task is to collect the resources and print them each on a new line. 
 * 
 * Print the resources and their quantities in format:
 * {resource} –> {quantity}
 * 
 * The quantities inputs will be in the range [1 … 2 000 000 000]
 * 
 * Example:
 * Input      Output
 * gold       gold -> 170
 * 155        silver -> 10
 * silver     copper -> 17
 * 10
 * copper
 * 17
 * gold
 * 15
 * stop
 * 
 * https://github.com/PavelDoynov
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace A_Miner_Task
{
    class MainClass
    {
        public static void Main()
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> collections = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!collections.ContainsKey(resource))
                {
                    collections[resource] = quantity;
                }
                else
                {
                    collections[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in collections)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
