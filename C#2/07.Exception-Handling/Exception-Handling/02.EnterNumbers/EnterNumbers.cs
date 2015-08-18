/*
Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/
using System;

    class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Please enter a number between {0} and {1}: ", start, end);
            try
            {
                int a = int.Parse(Console.ReadLine());

                if (a < start || a > end)
                {
                    throw new FormatException();
                }
                return a;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
                return -1;
            }
        }

        static void Main()
        {
            int count = 10;
            int start = 1;
            int end = 100;

            while (count > 0)
            {
                start = ReadNumber(start, end);
                if (start == -1)
                {
                    break;
                }
                count--;
            }
            if (count == 0)
            {
                Console.WriteLine("Ten numbers entered successfully");
            }
        }
    }

