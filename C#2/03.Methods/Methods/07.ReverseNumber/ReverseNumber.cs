//Write a method that reverses the digits of given decimal number.

using System;

    class ReverseNumber
    {
        static int ReverseDigits(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
            return reversed;
        }

        static void Main()
        {
            Console.Write("Please enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Reversed number: {0}", ReverseDigits(num));
        }
    }

