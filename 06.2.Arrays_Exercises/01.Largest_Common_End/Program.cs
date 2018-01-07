/*
 * 01. Largest Common End
 *
 * Read two arrays of words and find the length of the largest common end (left or right).
 * 
 * Example
 * Input                                           Output
 * hi php java csharp sql html css js              3
 * hi php java js softuni nakov java learn
 * 
 * Input
 * hi php java xml csharp sql html css js          Output
 * nakov java sql html css js                      4
 * 
 * Input                                           Output
 * I love programming                              0
 * Learn Java or C#
 * 
 * Hints
 * •   Scan the arrays from left to right until the end of the shorter is reached and count the equal elements.
 * •   Scan the arrays form right to left until the start of the shorter is reached.
 * •   Keep the start position and the length of the longest equal start / end.
 * 
 * https://github.com/PavelDoynov
*/


using System;

namespace Largest_Common_End
{
    class MainClass
    {
        public static void Main()
        {
            string[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int length = Math.Min(arr1.Length, arr2.Length);

            int startEnd = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    startEnd++;
                }
            }

            Array.Reverse(arr1);
            Array.Reverse(arr2);

            int endStart = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    endStart++;
                }
            }

            if (startEnd == 0 && endStart == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{Math.Max(startEnd, endStart)}");
            }
        }
    }
}
