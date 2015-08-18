/*
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/
using System;
using System.Globalization;
using System.Text.RegularExpressions;

    class DatesFromTextInCanada
    {
        static void Main()
        {
            string text = "Enter the first date: 27.02.2006, Enter the second date: 3.03.2006, Distance: 4 days";
            string patern = @"([0-9][0-9].[0-9][0-9].[0-9][0-9][0-9][0-9])";
            Match match = Regex.Match(text, patern);

            while (match.Success)
            {
                string stringDate = match.ToString();
                DateTime date;

                if (DateTime.TryParseExact(stringDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
                match = match.NextMatch();
            }
        }
    }

