/*
 * 07. Population Counter
 * 
 * So many people! It’s hard to count them all. But that’s your job as a statistician. 
 * You get raw data for a given city and you need to aggregate it. 
 * 
 * On each input line, you’ll be given data in format: "city|country|population". There will be no redundant whitespaces 
 * anywhere in the input. Aggregate the data by country and by city and print it on the console. 
 * 
 * For each country, print its total population and on separate lines, the data for each of its cities. 
 * Countries should be ordered by their total population in descending order and within each country, 
 * the cities should be ordered by the same criterion.
 * 
 * If two countries/cities have the same population, keep them in the order in which they were entered. 
 * Check out the examples; follow the output format strictly!
 * 
 * Input
 * •   The input data should be read from the console.
 * •   It consists of a variable number of lines and ends when the command "report" is received.
 * •   The input data will always be valid and in the format described. There is no need to check it explicitly.
 * 
 * Output
 * •   The output should be printed on the console.
 * •   Print the aggregated data for each country and city in the format shown below.
 * 
 * Constraints
 * •   The name of the city, country and the population count will be separated from each other by a pipe ('|').
 * •   The number of input lines will be in the range [2 … 50].
 * •   A city-country pair will not be repeated.
 * •   The population count of each city will be an integer in the range [0 … 2 000 000 000].
 * •   Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
 * 
 * Example
 * Input                               Output
 * Sofia|Bulgaria|1                    UK (total population: 4)
 * Veliko Tarnovo|Bulgaria|2           =>London: 4
 * London|UK|4                         Bulgaria (total population: 3)
 * Rome|Italy|3                        =>Veliko Tarnovo: 2
 * report                              =>Sofia: 1
 *                                     Italy (total population: 3)
 *                                     =>Rome: 3
*/
             

using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class MainClass
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] separatedInputArr = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string country = separatedInputArr[1];
                string city = separatedInputArr[0];
                long population = long.Parse(separatedInputArr[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, long>();
                    data[country][city] = population;
                }
                else
                {
                    if (!data[country].ContainsKey(city))
                    {
                        data[country][city] = population;
                    }
                    else
                    {
                        data[country][city] += population;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var country in data.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
