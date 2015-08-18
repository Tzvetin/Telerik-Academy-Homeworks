/*
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/

using System;

    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Dec: {0,15:D}", number);
            Console.WriteLine("Hex: {0,15:X4}", number);
            Console.WriteLine("Per: {0,15:P0}", number);
            Console.WriteLine("Sci: {0,15:E}", number);
        }
    }

