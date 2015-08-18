/*
Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.
*/
using System;

    class StringsInC
    {
        static void Main()
        {
            /*
Strings are sequences of characters. Each character is a Unicode symbol which supports multiple 
languages and alphabets. Strings are stored in the dynamic memory (managed heap). 
The string data type in C# (System.String) is a reference type. It contains an immutable (read-only) 
sequence of characters. String objects are like arrays of characters (char[]) and have fixed length 
(String.Length).Elements can be accessed directly by index. Before initializing a string variable 
has null value.

Most-important methods:
Compare(string s1, string s2) - Compares two strings alphanumerically
IndexOf(string str) - Finds the first occurrence of a char or string within a given string
LastIndexOf(string) - Finds the last occurrence
Substring(int startIndex, int length) - Extracts substrings
Split(params char[]) - Splits a string by given separator(s) 
Replace(string old, string new) – replaces all occurrences of given string with another
Remove(int startIndex, int length) – deletes part of a string and produces new string as result
ToLower() - Uppercase letters are changed to lowercase
ToUpper() - Lowercase letters are changed to uppercase
Trim() - Removes empty spaces or other symbols from the beggining and from the end
            */
        }
    }

