/*
 * 01. Blank Receipt
 * 
 * Create a method that prints a blank cash receipt. The method should invoke three other methods: one for printing 
 * the header, one for the body and one for the footer of the receipt. 
 * 
 * The header should contain the following text:     CASH RECEIPT
 *                                                   ------------------------------
 * 
 * The body should contain the following text:       Charged to____________________
 *                                                   Received by___________________
 * 
 * And the text for the footer:                      ------------------------------
 *                                                   © SoftUni
 * 
 * Output:
 * 
 *      CASH RECEIPT
 *      ------------------------------
 *      Charged to____________________
 *      Received by___________________
 *      ------------------------------
 *      © SoftUni
 *
 *
 * https://github.com/PavelDoynov
 */


using System;

namespace Blank_Receipt
{
    class MainClass
    {
        public static void Main()
        {
            Header();
            Body();
            Footer();
        }

        public static void Header ()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Body ()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer ()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
