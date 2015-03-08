using System;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Console.Write("Insert date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");
            date.AddHours(6).AddMinutes(30);
            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), provider);
        }
    }
}
