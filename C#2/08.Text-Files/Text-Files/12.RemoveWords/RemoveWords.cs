/*
Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

    class RemoveWords
    {
        static void Main()
        {
            try
            {
                StreamReader reader1 = new StreamReader(@"..\..\words.txt");
                Console.WriteLine("Processing 1st file...");
                List<string> words = new List<string>();
                string fileContent = "";

                using (reader1)
                {
                    while (reader1.EndOfStream == false)
                    {
                        words.Add(reader1.ReadLine().Trim());
                    }
                }
                StreamReader reader2 = new StreamReader(@"..\..\somefile.txt");
                Console.WriteLine("Processing 2nd file...");

                using (reader2)
                {
                    fileContent = reader2.ReadToEnd();
                }
                StreamWriter writer = new StreamWriter(@"..\..\output.txt");

                using (writer)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        fileContent = Regex.Replace(fileContent, words[i], "", RegexOptions.IgnoreCase);
                    }
                    writer.WriteLine(fileContent);
                }
                Console.WriteLine("Done.");
            }
            catch (AccessViolationException ave)
            {
                Console.Error.WriteLine(ave.Message);
            }
            catch (FileLoadException fle)
            {
                Console.Error.WriteLine(fle.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.Error.WriteLine(fnfe.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.Error.WriteLine(aoore.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.Error.WriteLine(ane.Message);
            }
        }
    }

