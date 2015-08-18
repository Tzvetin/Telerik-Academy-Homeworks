// Modify the solution of the previous problem to replace only whole words (not strings).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

    class ReplaceWholeWord
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somefile.txt");
            Console.WriteLine("Processing...");
            Regex regex = new Regex(@"\bstart\b");

            string fileContents = "";

            using (reader)
            {
                fileContents = reader.ReadToEnd();
                fileContents = regex.Replace(fileContents, "finish");
            }
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");

            using (writer)
            {
                writer.WriteLine(fileContents);
            }
            Console.WriteLine("Done.");
        }
    }

