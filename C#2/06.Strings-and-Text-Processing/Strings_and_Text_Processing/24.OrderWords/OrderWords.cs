//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;

    class OrderWords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] separators = {' '};
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }

