/*
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
*/
using System;

    class StringLength
    {
        static void Main()
        {
            int maxLength = 20;
            Console.WriteLine("Enter a string (max {0} chars): ", maxLength);
            string input = Console.ReadLine();

            if (input.Length > maxLength)
            {
                Console.WriteLine("Too long");
                Console.WriteLine(input.Substring(0, 20));
            }
            else if (input.Length == maxLength)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input.PadRight(maxLength, '*'));
            }
        }
    }

