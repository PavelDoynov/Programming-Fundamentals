/* 
 * 03. Employee Data
 * 
 * Write a program to read data about an employee and print it on the console with the appropriate formatting. 
 * The order the input comes in is as such:
 * -   Name – no formatting
 * -   Age – no formatting
 * -   Employee ID – 8-digit padding (employee id 356 is 00000356)
 * -   Monthly Salary – formatted to 2 decimal places (2345.56789 becomes 2345.56)
 * 
 * Example
 * Input       Output                          Input       Output
 * Ivan        Name: Ivan                      Naiden      Name: Naiden
 * 24          Age: 24                         27          Age: 27
 * 1192        Employee ID: 00001192           1111222     Employee ID: 01111222
 * 1500.353    Salary: 1500.35                 3650        Salary: 3560.00
 * 
 * 
 * https://github.com/PavelDoynov
*/

using System;

namespace EmployeeData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine("Employee ID: {0}", employeeID.ToString("D8"));
            Console.WriteLine($"Salary: {salary:f2}");

            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine(num.ToString("D8"));
        }
    }
}