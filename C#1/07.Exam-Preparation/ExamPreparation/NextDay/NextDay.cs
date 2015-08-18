using System;

    class NextDay
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(year, month, day);
            currentDate = currentDate.AddDays(1);
            Console.WriteLine(currentDate.Day + "." + currentDate.Month + "." + currentDate.Year);

           /* int nextDay = day;
            int nextMonth = month;
            int nextYear = year; 
            if (month == 12 && day == 31)
            {
                nextDay = 1;
                nextMonth = 1;
                nextYear = year + 1;
            }
            else if (month == 2 && day == 28)
            {
                nextDay = 1;
                nextMonth = 3;
            }
            else if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10) && (day==31))
            {
                nextDay = 1;
                nextMonth = month + 1;
            }
            else if ((month == 4 || month == 6 || month == 9 || month == 11) && (day == 30))
            {
                nextDay = 1;
                nextMonth = month + 1;
            }
            else
            {
                nextDay = day + 1;
            }
            //Output
            Console.WriteLine("{0}.{1}.{2}", nextDay, nextMonth, nextYear);*/
        }
    }

