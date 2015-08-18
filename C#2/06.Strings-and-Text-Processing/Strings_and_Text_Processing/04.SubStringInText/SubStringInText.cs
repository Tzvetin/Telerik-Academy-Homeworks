//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
using System;
using System.Text.RegularExpressions;

    class SubStringInText
    {
        static int CountSubstrings(string textToCheck, string textToFind)
        {
            int count = 0;
            int index = textToCheck.IndexOf(textToFind, 0);

            while (index != -1)
            {
                count++;
                index = textToCheck.IndexOf(textToFind, index + 1);
            }

            return count;
        }

        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
           
            Console.Write("Case sensitive: ");
            Console.WriteLine(CountSubstrings(text, "in"));

            Console.Write("Case insensitive: ");
            Console.WriteLine(Regex.Matches(text, "in", RegexOptions.IgnoreCase).Count);
        }
    }

