/*
Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
 * reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/
using System;
using System.IO;
using System.Security;

    class ReadFileContents
    {
        static void Main()
        {
            Console.WriteLine("Please enter the path to the file: ");
            try
            {
                string path = Console.ReadLine();
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine(fnf.Message);
            }
            catch (ArgumentNullException an)
            {
                Console.WriteLine(an.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (PathTooLongException ptl)
            {
                Console.WriteLine(ptl.Message);
            }
            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine(dnf.Message);
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (UnauthorizedAccessException ua)
            {
                Console.WriteLine(ua.Message);
            }
            catch (NotSupportedException ns)
            {
                Console.WriteLine(ns.Message);
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message);
            }
        }
    }

