/*
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
*/
using System;
using System.Collections.Generic;

    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> wordDict = new Dictionary<string, string>();

            wordDict.Add(".NET", "platform for applications from Microsoft");
            wordDict.Add("CLR", "managed execution environment for .NET");
            wordDict.Add("namespace", "hierarchical organization of classes");

            string word = ".NET";

            if (wordDict.ContainsKey(word))
            {
                Console.Write("{0} - ", word);
                Console.WriteLine(wordDict[word]);
            }
            else
            {
                Console.WriteLine("Entry not found");
            }
        }
    }

