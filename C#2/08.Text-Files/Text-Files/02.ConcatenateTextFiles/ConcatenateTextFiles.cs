// Write a program that concatenates two text files into another text file.
using System;
using System.IO;

    class ConcatenateTextFiles
    {
        static void Main()
        {
            string file1Contents;
            string file2Contents;
            Console.WriteLine("Processing...");

            StreamReader reader1 = new StreamReader(@"..\..\file1.txt");
            
            using (reader1)
            {
                file1Contents = reader1.ReadToEnd();
            }
            
            StreamReader reader2 = new StreamReader(@"..\..\file2.txt");
            
            using (reader2)
            {
                file2Contents = reader2.ReadToEnd();
            }
            
            StreamWriter writer = new StreamWriter(@"..\..\file3.txt");
            
            using (writer)
            {
                writer.WriteLine(file1Contents + Environment.NewLine + file2Contents);
            }
            Console.WriteLine("Done.");
        }
    }

