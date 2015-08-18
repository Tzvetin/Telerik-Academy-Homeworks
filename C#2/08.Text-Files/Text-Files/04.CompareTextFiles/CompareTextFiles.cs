/*
Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/
using System;
using System.IO;

    class CompareTextFiles
    {
        static void Main()
        {
            StreamReader reader1 = new StreamReader(@"..\..\file1.txt");
            StreamReader reader2 = new StreamReader(@"..\..\file2.txt");
            Console.WriteLine("Processing...");

            using (reader1)
            {
                using (reader2)
                {
                    string lineFirst = reader1.ReadLine();
                    string lineSecond = reader2.ReadLine();
                    int numberSame = 0;
                    int numberDifferent = 0;

                    while (lineFirst != null && lineSecond != null)
                    {
                        if (lineFirst == lineSecond)
                        {
                            numberSame++;
                        }
                        else
                        {
                            numberDifferent++;
                        }
                        lineFirst = reader1.ReadLine();
                        lineSecond = reader2.ReadLine();
                    }
                    Console.WriteLine("Done.");
                    Console.WriteLine("The number of lines that are the same is {0}", numberSame);
                    Console.WriteLine("The number of lines that are different is {0}", numberDifferent);
                }
            }
           
        }
    }

