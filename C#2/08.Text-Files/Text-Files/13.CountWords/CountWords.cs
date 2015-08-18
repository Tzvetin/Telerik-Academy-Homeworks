/*
Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

    class CountWords
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
                StreamReader reader2 = new StreamReader(@"..\..\test.txt");
                Console.WriteLine("Processing 2nd file...");

                using (reader2)
                {
                    fileContent = reader2.ReadToEnd();
                }
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");
                string[] wordsArray = new string[words.Count];
                int[] wordsCount = new int[words.Count];

                using (writer)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        wordsArray[i] = words[i];
                        MatchCollection matches = Regex.Matches(fileContent, words[i], RegexOptions.IgnoreCase);
                        wordsCount[i] = matches.Count;
                    }
                    Array.Sort(wordsCount, wordsArray);

                    for (int j = words.Count - 1; j >= 0; j--)
                    {
                        writer.WriteLine("Word: {0}, Count: {1}", wordsArray[j], wordsCount[j]);
                    }
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

