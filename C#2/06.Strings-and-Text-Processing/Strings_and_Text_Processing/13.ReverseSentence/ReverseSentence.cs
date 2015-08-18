//Write a program that reverses the words in given sentence.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            string regex = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|\!\s*|\?\s*|\.\s*";
            Stack<string> words = new Stack<string>();
            Queue<string> separators = new Queue<string>();
            string[] wordsInSentence = Regex.Split(sentence, regex);

            foreach (string word in wordsInSentence)
            {
                if (word != "")
                {
                    words.Push(word);
                }
            }
            MatchCollection separatorsInSentence = Regex.Matches(sentence, regex);

            foreach (Match separator in separatorsInSentence)
            {
                separators.Enqueue(separator.ToString());
            }
            StringBuilder reversedSentence = new StringBuilder();

            while (words.Count > 0 && separators.Count > 0)
            {
                reversedSentence.Append(words.Pop());
                reversedSentence.Append(separators.Dequeue());
            }
            Console.WriteLine(reversedSentence.ToString());
        }
    }

