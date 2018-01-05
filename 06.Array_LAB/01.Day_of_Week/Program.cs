/*
 * 01.  Day of Week
 * 
 * Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”. Use an array of strings.
 * 
 * Example
 * Input         Output
 *   1           Monday
 *  
 * Input         Output
 *   0           Invalid Day!
 * 
 * Hints
 * •   Use an array of strings holding the day names: 
 *                   {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}.
 * •   Print the element at index (day-1) when it is in the range [1…7] or “Invalid Day!” otherwise.
*/


using System;

namespace Day_of_Week
{
    class MainClass
    {
        public static void Main()
        {
            string[] days = new string[]
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 7)
            {
                input -= 1;

                for (int i = 0; i < days.Length; i++)
                {
                    if (i == input)
                    {
                        Console.WriteLine("{0}", days[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
