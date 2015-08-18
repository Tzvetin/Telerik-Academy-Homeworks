using System;

    class TrailingZeroesInNFactorial
    {
        static void Main()
        {
            Console.Write("Please enter the number: ");
            long number = long.Parse(Console.ReadLine());
            long result = 0;

            for (int i = 5; i <= number; i *= 5)
            {
                result = result + (number / i);
            }
            Console.WriteLine("Trailing zeroes of {0}! are {1}.", number, result);
        }
    }

