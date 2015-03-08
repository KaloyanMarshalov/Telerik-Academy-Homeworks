using System;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

namespace _16.DateDifferance
{
    class Difference
    {
        static void Main()
        {
            Console.Write("Insert first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Insert second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            int daysBetween = (int)(secondDate - firstDate).TotalDays;
            Console.WriteLine("Days between: " + daysBetween);
        }
    }
}
