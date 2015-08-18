/*
Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/
using System;
using System.IO;
using System.Collections.Generic;

    class DeleteOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somefile.txt");
            Console.WriteLine("Processing...");
            List<string> lines = new List<string>();

            using (reader)
            {
                while (reader.EndOfStream == false)
                {
                    lines.Add(reader.ReadLine());
                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\somefile.txt");

            using (writer)
            {
                for (int i = 1; i < lines.Count; i += 2)
                {
                    writer.WriteLine(lines[i]);
                }
            }
            Console.WriteLine("Done.");
        }
    }

