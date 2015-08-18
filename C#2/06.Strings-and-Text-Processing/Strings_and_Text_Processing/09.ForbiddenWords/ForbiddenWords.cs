/*
We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
*/
using System;

    class ForbiddenWords
    {
        static void Main()
        {
            string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";

            string[] forbiddenWords = words.Split(',');

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                forbiddenWords[i] = forbiddenWords[i].Trim();
                str = str.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine(str);
        }
    }

