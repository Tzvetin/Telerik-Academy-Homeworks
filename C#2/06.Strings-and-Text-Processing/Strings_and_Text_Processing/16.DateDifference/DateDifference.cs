//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;
using System.Globalization;

    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the start date in format day.month.year: ");
            string input1 = Console.ReadLine();
            DateTime start = DateTime.ParseExact(input1, "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Enter the end date in format DD.MM.YYYY: ");
            string input2 = Console.ReadLine();
            DateTime end = DateTime.ParseExact(input2, "d.M.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Between {0} and {1} there are {2} days", start, end, (end - start).TotalDays);
        }
    }

