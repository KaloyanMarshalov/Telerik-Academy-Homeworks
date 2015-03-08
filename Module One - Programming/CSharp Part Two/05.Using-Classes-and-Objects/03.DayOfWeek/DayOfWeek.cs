using System;

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            var today = DateTime.Now.DayOfWeek;
            Console.WriteLine(today);
        }
    }
}
