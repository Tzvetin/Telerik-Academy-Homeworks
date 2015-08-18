/*
Write a program that reads a string from the console and prints all different letters in the string 
along with information how many times each letter is found.
*/
using System;
using System.Text.RegularExpressions;

    class LettersCount
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            
            for (char c = 'a'; c <= 'z'; c++)
            {
                Regex regex = new Regex(c.ToString(), RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(text);

                if (matches.Count > 0)
                {
                    Console.WriteLine(c.ToString() + '-' + matches.Count);
                }
            }

            Console.WriteLine("Another solution:");
            int[] count = new int['z' - 'a' + 1];
            text = text.ToLower();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    count[text[i] - 'a']++;
                }
            }
            for (int j = 0; j < count.Length; j++)
            {
                if (count[j] > 0)
                {
                    Console.WriteLine("{0}-{1}", (char)(j + 'a'), count[j]);
                }
            }
        }
    }

