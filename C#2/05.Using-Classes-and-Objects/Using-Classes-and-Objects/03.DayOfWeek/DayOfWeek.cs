﻿/*
Write a program that prints to the console which day of the week is today.
Use System.DateTime.
*/
using System;

    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = new DateTime();
            today = DateTime.Now;
            Console.WriteLine(today.DayOfWeek); 
        }
    }

