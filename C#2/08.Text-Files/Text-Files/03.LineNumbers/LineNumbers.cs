/*
Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/
using System;
using System.IO;

    class LineNumbers
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
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Done.");
        }
    }

