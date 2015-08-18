//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
using System;
using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            //string input = "aaaaabbbbbcdddeeeedssaa";
            string input = Console.ReadLine().ToLower();
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    continue;
                }
                else
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output.ToString()); 
        }
    }

