/*
Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/
using System;
using System.Collections.Generic;
using System.Text;

    class UnicodeCharacters
    {
        static string ConvertToUnicode(string str)
        {
            StringBuilder utf = new StringBuilder(str.Length * 6);

            foreach (char c in str)
            { 
                utf.AppendFormat("\\u{0:X4}", (int)c);
            }

            return utf.ToString();
        }

        static string FormatString(string str)
        {
            List<int> list = new List<int>();
            string result = string.Empty;

            foreach (var ch in str)
            {
                list.Add(ch + '\0');
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
                string formatted = string.Format("\\u{0:X4}", item);
                result += formatted;
            }
            return result;
        }

        static void Main()
        {
            string input = "Hi!";
            Console.WriteLine(ConvertToUnicode(input));
            Console.WriteLine(FormatString(input));
        }
    }

