/*
Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/
using System;
using System.Collections.Generic;

    class Workdays
    {
        static int CalculateWorkdays(DateTime startDay, DateTime endDay)
        {
            List<DateTime> officialHolidays = new List<DateTime>()
            {
                new DateTime (2015, 01, 01), new DateTime (2015, 03, 03), new DateTime (2015, 05, 01), new DateTime (2015, 05, 06),
                new DateTime (2015, 05, 24), new DateTime (2015, 09, 22), new DateTime (2015, 12, 24), new DateTime (2015, 12, 25)
            };
            int workingDays = 0;

            while (startDay < endDay)
            {
                if (!((startDay.DayOfWeek == DayOfWeek.Saturday) || (startDay.DayOfWeek == DayOfWeek.Sunday) || (officialHolidays.Contains(startDay))))
                {
                    workingDays++;
                }
                startDay = startDay.AddDays(1);
            }
            return workingDays;
        }

        static void Main()
        {
            Console.Write("Enter the end date in format YYYY, MM, DD: ");
            DateTime end = DateTime.Parse(Console.ReadLine());
            DateTime start = DateTime.Today;
            Console.WriteLine("Between {0} and {1} there are {2} working days", start, end, CalculateWorkdays(start, end));
        }
    }

