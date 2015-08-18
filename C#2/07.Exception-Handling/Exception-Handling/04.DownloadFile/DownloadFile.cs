/*
Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
*/
using System;
using System.Net;

    class DownloadFile
    {
        static void Main()
        {
            WebClient webClient = new WebClient();

            using (webClient)
            {
                try
                {
                    Console.WriteLine("Downloading file...");
                    webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"d:\myfile.jpg");
                    Console.WriteLine("Done.");
                }
                catch (ArgumentNullException an)
                {
                    Console.WriteLine("ArgumentNullException: " + an.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("ArgumentException: " + ae.Message);
                }
                catch (WebException we)
                {
                    Console.WriteLine("WebException: " + we.Message);
                }
                catch (NotSupportedException ns)
                {
                    Console.WriteLine("NotSupportedException: " + ns.Message);
                }
                finally
                {
                    webClient.Dispose();
                    GC.Collect();
                }
            }
        }
    }

