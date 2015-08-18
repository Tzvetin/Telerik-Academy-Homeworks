//Write a program that extracts from a given text all sentences containing given word.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Linq;
using System.Text;

    class ExtractSentences
    {
        static void Main()
        {
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            StringBuilder result = new StringBuilder();
            string[] sentences = str.Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(' ', ',');

                if (words.Contains("in") || words.Contains("In"))
                {
                    result.Append(sentences[i]);
                    result.Append('.');
                }
            }
            Console.WriteLine(result.ToString());
        }
    }

