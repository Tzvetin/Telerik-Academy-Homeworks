//Write a method that returns the last digit of given integer as an English word.

using System;

    class EnglishDigit
    {
        static string LastDigit(int number)
        {
            if (number < 0)
            {
                number = -number;
            }
            int lastDigitOfNumber = number % 10;

            switch (lastDigitOfNumber)
            {
                case (0): return "zero";
                case (1): return "one";
                case (2): return "two";
                case (3): return "three";
                case (4): return "four";
                case (5): return "five";
                case (6): return "six";
                case (7): return "seven";
                case (8): return "eight";
                case (9): return "nine";
                default: return "error";
            }
        }

        static void Main()
        {
            Console.Write("Please enter the number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is: {0}", LastDigit(n)); 
        }
    }

