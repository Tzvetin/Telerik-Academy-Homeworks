/*
Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

    class PrefixTest
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somefile.txt");
            Console.WriteLine("Processing...");
            Regex regex = new Regex(@"\b(test\w*)\b");
            string fileContents = "";
            // string output = "";

            using (reader)
            {
                fileContents = reader.ReadToEnd();
                fileContents = regex.Replace(fileContents, "");
            }
            StreamWriter writer = new StreamWriter(@"..\..\somefile.txt");

            using (writer)
            {
                writer.WriteLine(fileContents);
            }
            Console.WriteLine("Done.");
        }
    }

