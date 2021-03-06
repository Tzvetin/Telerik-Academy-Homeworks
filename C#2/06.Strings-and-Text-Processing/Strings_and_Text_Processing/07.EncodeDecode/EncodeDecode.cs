﻿/*
Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation 
over the first letter of the string with the first of the key, 
the second – with the second, etc. When the last key character is reached, the next is the first.
*/
using System;
using System.Text;

    class EncodeDecode
    {
        static string Encrypt(string input, string key)
        {
            StringBuilder result = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] ^ key[i % key.Length]));
            }
      
            return result.ToString();

        }

        static void Main()
        {
            string str = "I'd become accustomed to behaviour like this from both my parents - behaviour that anyone else would find abhorrent - and I was emotionally numb to their threats.";
            string cipher = "Killer";

            str = Encrypt(str, cipher);
            str = Encrypt(str, cipher);
            Console.WriteLine(str);
        }
    }

