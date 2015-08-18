using System;
using System.Text;

    class MovingLetters
    {
        static StringBuilder ExtractLetters(string[] words)
        {
            int maxWordLength = 0;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                if (maxWordLength < words[i].Length)
                {
                    maxWordLength = words[i].Length;
                }
            }
            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    string currentWord = words[j];
                    if (i < currentWord.Length)
                    {
                        int lastLetter = currentWord.Length - 1 - i;
                        result.Append(currentWord[lastLetter]);
                    }
                }
            }
            return result;
        }

        static string MoveLetters(StringBuilder StrangeWords)
        {
            for (int i = 0; i < StrangeWords.Length; i++)
            {
                char currentSymbol = StrangeWords[i];
                int transition = char.ToLower(currentSymbol) - 'a' + 1;
                int nextPosition = (i + transition) % StrangeWords.Length;
                StrangeWords.Remove(i, 1);
                StrangeWords.Insert(nextPosition, currentSymbol);
            }
            return StrangeWords.ToString();
        }
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder strangeCombination = ExtractLetters(words);
            string finalResult = MoveLetters(strangeCombination);
            Console.WriteLine(finalResult);
        }
    }

