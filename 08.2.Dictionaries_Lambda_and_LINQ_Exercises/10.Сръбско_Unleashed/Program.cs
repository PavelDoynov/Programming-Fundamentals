/*
 * 10. Сръбско Unleashed
 * 
 * Admit it – the СРЪБСКО is your favorite sort of music. You never miss a concert and you have become quite 
 * the geek concerning everything involved with СРЪБСКО. You can’t decide between all the singers you know who 
 * your favorite one is. One way to find out is to keep statistics of how much money their concerts make.
 * Write a program that does all the boring calculations for you.
 * 
 * On each input line you’ll be given data in format: "singer @venue ticketsPrice ticketsCount". 
 * There will be no redundant whitespaces anywhere in the input. Aggregate the data by venue and by singer. 
 * For each venue, print the singer and the total amount of money his/her concerts have made on a separate line.
 * Venues should be kept in the same order they were entered; the singers should be sorted by how much money they 
 * have made in descending order. If two singers have made the same amount of money, keep them in the order in 
 * which they were entered.
 * 
 * Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output.
 * Each of the four tokens must be separated by a space, everything else is invalid. The venue should be denoted 
 * with @ in front of it, such as @Sunny Beach
 * 
 * SKIP THOSE: Ceca@Belgrade125 12378, Ceca @Belgrade12312 123
 * 
 * The singer and town name may consist of one to three words. 
 * 
 * Input:
 * •   The input data should be read from the console.
 * •   It consists of a variable number of lines and ends when the command “End" is received.
 * •   The input data will always be valid and in the format described. There is no need to check it explicitly.
 * 
 * Output:
 * •   The output should be printed on the console.
 * •   Print the aggregated data for each venue and singer in the format shown below.
 * •   Format for singer lines is #{2*space}{singer}{space}->{space}{total money}.
 * 
 * Constraints
 * •   The number of input lines will be in the range [2 … 50].
 * •   The ticket price will be an integer in the range [0 … 200].
 * •   The ticket count will be an integer in the range [0 … 100 000]
 * •   Singers and venues are case sensitive
 * •   Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
 * 
 * Example
 * Input                                          Output
 * Lepa Brena @Sunny Beach 25 3500                Sunny Beach
 * Dragana@Belgrade23 3500                        #  Saban Saolic -> 4200000
 * Ceca @Sunny Beach 28 3500                      #  Ceca -> 1148000
 * Mile Kitic @Sunny Beach 21 3500                #  Lepa Brena -> 87500
 * Ceca @Belgrade 35 3500                         #  Mile Kitic -> 73500
 * Ceca @Sunny Beach 70 15000                     Belgrade
 * Saban Saolic @Sunny Beach 120 35000            #  Ceca -> 122500
 * End
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace Сръбско_Unleashed
{
    class MainClass
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] singerArr = input.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] singerCurrentArr = singerArr[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    bool checker = false;
                    string singer = null;

                    if (singerCurrentArr.Length >= 1 && singerCurrentArr.Length <= 3)
                    {
                        singer = singerArr[0];
                        checker = true;
                    }

                    string[] townAndTicketsArr = singerArr[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string town = null;

                    for (int i = 0; i < townAndTicketsArr.Length - 2; i++)
                    {
                        town += " " + townAndTicketsArr[i];
                    }

                    long income = 0;
                    int ticketPrice = int.Parse(townAndTicketsArr[townAndTicketsArr.Length - 2]);
                    int ticketNumber = int.Parse(townAndTicketsArr[townAndTicketsArr.Length - 1]);

                    income = ticketPrice * ticketNumber;

                    if (!data.ContainsKey(town) && townAndTicketsArr.Length >= 3 && townAndTicketsArr.Length <= 5 && checker == true)
                    {
                        data[town] = new Dictionary<string, long> { { singer, income } };
                    }
                    else if (townAndTicketsArr.Length >= 3 && townAndTicketsArr.Length <= 5 && checker == true)
                    {
                        if (!data[town].ContainsKey(singer))
                        {
                            data[town][singer] = income;
                        }
                        else
                        {
                            data[town][singer] += income;
                        }
                    }

                }
                catch (Exception)
                {
                    
                }

                input = Console.ReadLine();
            }

            foreach (var town in data)
            {
                Console.WriteLine($"{town.Key}");

                foreach (var singer in town.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}

