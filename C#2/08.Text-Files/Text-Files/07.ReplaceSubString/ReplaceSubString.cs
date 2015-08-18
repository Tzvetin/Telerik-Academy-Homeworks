/*
Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/
using System;
using System.Collections.Generic;
using System.IO;

    class ReplaceSubString
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somefile.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            Console.WriteLine("Processing...");

            using (reader)
            {
                using (writer)
                {
                    string fileContent = reader.ReadToEnd();
                    string output = fileContent.Replace("start", "finish");
                    writer.WriteLine(output);
                }
            }
            Console.WriteLine("Done.");
        }
    }

