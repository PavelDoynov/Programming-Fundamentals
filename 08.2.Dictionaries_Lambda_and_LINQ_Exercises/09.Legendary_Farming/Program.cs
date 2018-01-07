/*
 * 09. Legendary Farming
 * 
 * You’ve beaten all the content and the last thing left to accomplish is own a legendary item. However, 
 * it’s a tedious process and requires quite a bit of farming. Anyway, you are not too pretentious – any legendary will do.
 * The possible items are:
 * •   Shadowmourne – requires 250 Shards;
 * •   Valanyr – requires 250 Fragments;
 * •   Dragonwrath – requires 250 Motes;
 * 
 * Shards, Fragments and Motes are the key materials, all else is junk. You will be given lines of input, such as 
 * 2 motes 3 ores 15 stones. Keep track of the key materials - the first that reaches the 250 mark wins the race. 
 * At that point, print the corresponding legendary obtained. Then, print the remaining shards, fragments, motes, 
 * ordered by quantity in descending order, then by name in ascending order, each on a new line.
 * Finally, print the collected junk items, in alphabetical order.
 * 
 * Input
 * •    Each line of input is in format {quantity} {material} {quantity} {material} … {quantity} {material}
 * 
 * Output
 * •   On the first line, print the obtained item in format {Legendary item} obtained!
 * •   On the next three lines, print the remaining key materials in descending order by quantity
 *   o   If two key materials have the same quantity, print them in alphabetical order
 * •   On the final several lines, print the junk items in alphabetical order
 *   o   All materials are printed in format {material}: {quantity}
 *   o   All output should be lowercase, except the first letter of the legendary
 * 
 * Constraints
 * •   The quantity-material pairs are between 1 and 25 per line.
 * •   The number of lines is in range [1..10]
 * •   All materials are case-insensitive.
 * •   Allowed working time: 0.25s
 * •   Allowed memory: 16 MB
 * 
 * Example
 * Input                                          Output
 * 123 silver 6 shards 8 shards 5 motes           Dragonwrath obtained!
 * 9 fangs 75 motes 103 MOTES 8 Shards            shards: 22
 * 86 Motes 7 stones 19 silver                    motes: 19
 *                                                fragments: 0
 *                                                fangs: 9
 *                                                silver: 123
 * 
 * https://github.com/PavelDoynov
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class MainClass
    {
        public static void Main()
        {
            Dictionary<string, int> keyMaterialsData = new Dictionary<string, int> ();
            keyMaterialsData.Add("motes", 0);
            keyMaterialsData.Add("shards", 0);
            keyMaterialsData.Add("fragments", 0);
            Dictionary<string, int> junkMaterialsData = new Dictionary<string, int>();

            bool checker = true;

            int shards = 0;
            int motes = 0;
            int fragments = 0;

            while (checker != false)
            {
                string[] input = Console.ReadLine()
                                        .ToLower()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {
                    int value = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMaterialsData.ContainsKey(material))
                    {
                        keyMaterialsData[material] += value;

                        if (material == "motes")
                        {
                            motes += value;
                        }
                        else if (material == "shards")
                        {
                            shards += value;
                        }
                        else if (material == "fragments")
                        {
                            fragments += value;
                        }

                        if (fragments >= 250 || motes >= 250 || shards >= 250)
                        {
                            checker = false;
                            break;
                        }
                    }

                    else
                    {
                        if (!junkMaterialsData.ContainsKey(material))
                        {
                            junkMaterialsData[material] = value;
                        }
                        else
                        {
                            junkMaterialsData[material] += value;
                        }
                    }
                }
            }

            if (fragments >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterialsData["fragments"] -= 250;
            }
            else if (motes >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterialsData["motes"] -= 250;
            }
            else if (shards >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterialsData["shards"] -= 250;
            }

            foreach (var item in keyMaterialsData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterialsData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
