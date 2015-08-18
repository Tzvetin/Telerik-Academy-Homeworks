/*
    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
*/
using System;

    class IndexOfLetters
    {
        static void Main()
        {
            int[] alphabet = new int[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = 'a' + i;
            }

            string test = Console.ReadLine();
            for (int i = 0; i < test.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (test[i] == alphabet[j])
                    {
                        Console.Write("{0} ", j + 1);
                    }
                }
            }
            Console.WriteLine();
        }
    }

