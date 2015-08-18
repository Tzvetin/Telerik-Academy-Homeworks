/*
Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/
using System;

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Please enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
        }
    }

