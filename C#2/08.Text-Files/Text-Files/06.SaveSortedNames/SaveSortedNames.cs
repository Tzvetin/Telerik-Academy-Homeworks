// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
using System;
using System.IO;
using System.Collections.Generic;

    class SaveSortedNames
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
                    List<string> names = new List<string>();

                    while (reader.EndOfStream == false)
                    {
                        names.Add(reader.ReadLine());
                    }
                    names.Sort();

                    for (int i = 0; i < names.Count; i++)
                    {
                        writer.WriteLine(names[i]);
                    }
                }
            }
            Console.WriteLine("Done.");
        }
    }

