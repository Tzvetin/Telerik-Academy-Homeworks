// Write a program that extracts from given XML file all the text without the tags.
using System;
using System.Collections.Generic;
using System.IO;

    class ExtractTextFromXML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\xml.txt");
            Console.WriteLine("Processing...");
            List<string> XML = new List<string>();

            using (reader)
            {
                string line;

                while (reader.EndOfStream == false)
                {
                    line = reader.ReadLine();

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (i < line.Length - 1 && line[i] == '>' && line[i + 1] != '<')
                        {
                            int wordStart = i + 1;
                            int wordLength = 0;

                            while (line[i] != '<')
                            {
                                wordLength++;
                                i++;
                            }
                            XML.Add(line.Substring(wordStart, wordLength - 1));
                        }
                    }
                }
            }

            for (int j = 0; j < XML.Count; j++)
            {
                XML[j].Trim();
                Console.WriteLine(XML[j]);
            }
            Console.WriteLine("Done.");
        }
    }

