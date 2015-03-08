using System;
using System.Globalization;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Insert date of the format: dd.MM.yyyy");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            int year = date.Year;
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine(isLeap);
        }
    }
}
