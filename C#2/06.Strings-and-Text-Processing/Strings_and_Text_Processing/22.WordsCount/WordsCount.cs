/*
Write a program that reads a string from the console and lists all different words in the string 
along with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

    class WordsCount
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found";
            Regex aWord = new Regex(@"\b\w+\b");
            MatchCollection allWords = aWord.Matches(text);
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            
            foreach (Match word in allWords)
            {
                if (wordDict.ContainsKey(word.Value))
                {
                    wordDict[word.Value] += 1;
                }
                else
                {
                    wordDict.Add(word.Value, 1);
                }
            }

            foreach (var eachWord in wordDict)
            {
                Console.Write(eachWord.Key + '-');
                Console.WriteLine(eachWord.Value);
            }
        }
    }

