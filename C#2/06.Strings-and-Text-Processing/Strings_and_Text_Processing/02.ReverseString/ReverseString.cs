//Write a program that reads a string, reverses it and prints the result at the console.
using System;
using System.Text;

    class ReverseString
    {
        public static string ReverseStr(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            string str = "kuma liso";
            Console.WriteLine(ReverseStr(str));
            Console.WriteLine(Reverse(str));
        }
    }

