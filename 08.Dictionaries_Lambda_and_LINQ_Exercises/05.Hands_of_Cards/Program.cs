/*
 * 05. Hands of Cards
 * 
 * You are given a sequence of people and for every person what cards he draws from the deck. 
 * The input will be separate lines in the format:
 * 
 * •    {personName}: {PT, PT, PT,… PT}
 * 
 * Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. 
 * The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
 * The input will always be valid and in the format described, there is no need to check it.
 * 
 * A single person cannot have more than one card with the same power and type, if they draw such a card they discard it. 
 * The people are playing with multiple decks. Each card has a value that is calculated by the power multiplied by the type.
 * 
 * Powers 2 to 10 have the same value and J to A are 11 to 14. 
 * Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
 * 
 * Finally print out the total value each player has in his hand in the format:
 * •   {personName}: {value}
 * 
 * Example:
 * Input                                    Output
 * Pesho: 2C, 4H, 9H, AS, QS                Pesho: 167
 * Slav: 3H, 10S, JC, KD, 5S, 10S           Slav: 175
 * Peshoslav: QH, QC, QS, QD                Peshoslav: 197
 * Slav: 6H, 7S, KC, KD, 5S, 10C
 * Peshoslav: QH, QC, JS, JD, JC
 * Pesho: JD, JD, JD, JD, JD, JD
 * JOKER
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    class MainClass
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            string nameCommand = input[0];

            Dictionary<string, List<string>> currentData = new Dictionary<string, List<string>>();

            while (nameCommand != "JOKER") 
            {
                string[] personCards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();
                
                List<string> cards = new List<string>();

                for (int i = 0; i < personCards.Length; i++)
                {
                    if (!cards.Contains(personCards[i]))
                    {
                        cards.Add(personCards[i]);
                    }
                }

                if (!currentData.ContainsKey(nameCommand))
                {
                    currentData[nameCommand] = cards;
                }
                else
                {
                    for (int i = 0; i < cards.Count(); i++)
                    {
                        if (!currentData[nameCommand].Contains(cards[i]))
                        {
                            currentData[nameCommand].Add(cards[i]);
                        }
                    }
                }

                input = Console.ReadLine()
                                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                nameCommand = input[0];
            }

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in currentData)
            {
                for (int i = 0; i < item.Value.Count; i++)
                { 
                    if (!result.ContainsKey(item.Key)) 
                    {
                        result[item.Key] = AnyCard(item.Value[i]);
                    }
                    else
                    {
                        result[item.Key] += AnyCard(item.Value[i]);
                    }
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }

        public static int AnyCard (string str)
        {
            int result = 0;

            if (str.Length == 2) 
            {
                if (str.EndsWith("S"))
                {
                    result = CardValue(str[0]) * 4;
                }
                else if (str.EndsWith("H"))
                {
                    result = CardValue(str[0]) * 3;
                }
                else if (str.EndsWith("D"))
                {
                    result = CardValue(str[0]) * 2;
                }
                else if (str.EndsWith("C"))
                {
                    result = CardValue(str[0]) * 1;
                }
            }
            else if (str.Length == 3) 
            {
                if (str.EndsWith("S")) 
                {
                    result = 10 * 4;
                }
                else if (str.EndsWith("H"))
                {
                    result = 10 * 3;
                }
                else if (str.EndsWith("D"))
                {
                    result = 10 * 2;
                }
                else if (str.EndsWith("C"))
                {
                    result = 10 * 1;
                }
            }

            return result; 
        }

        public static int CardValue (char str)
        {
            int result = 0;

            switch (str) 
            {
                case '2':
                    result = 2;
                    break;
                case '3':
                    result = 3;
                    break;
                case '4':
                    result = 4;
                    break;
                case '5':
                    result = 5;
                    break;
                case '6':
                    result = 6;
                    break;
                case '7':
                    result = 7;
                    break;
                case '8':
                    result = 8;
                    break;
                case '9':
                    result = 9;
                    break;
                case 'J':
                    result = 11;
                    break;
                case 'Q':
                    result = 12;
                    break;
                case 'K':
                    result = 13;
                    break;
                case 'A':
                    result = 14;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
