using System;
using System.Collections.Generic;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

namespace _05.Workdays
{
    class Workdays
    {
        static List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(2015, 01, 01), new DateTime(2015, 03, 03), new DateTime(2015, 05, 24),
                new DateTime(2015, 09, 06),new DateTime(2015, 09, 22), new DateTime(2015, 11, 01)
            };
        static int CalculateWorkdays(DateTime endDate)
        {
            DateTime now = DateTime.Now;
            int workdays = 0;
            while (endDate.Date != now.Date)
            {
                if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                {
                    now = now.AddDays(1);
                    continue;
                }
                else
                {
                    bool isHoliday = false;
                    foreach (var holiday in holidays)
                    {
                        if (holiday.Month == now.Month && holiday.Day == now.Day)
                        {
                            isHoliday = true;
                            break;
                        }
                    }
                    if (!isHoliday)
                    {
                        workdays++;
                    }
                    now = now.AddDays(1);
                }
            }
            return workdays;
        }
        static void Main()
        {
            Console.WriteLine("Enter date in format dd.MM.yyyy");
            DateTime input = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            int workdays = CalculateWorkdays(input);
            Console.WriteLine(workdays);
        }
    }
}
