/*
Write a program that parses an URL address given in the format: 
[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
*/
using System;

    class ParseURL
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            int start = url.IndexOf(':');
            int end = url.IndexOf('/', start + 3);

            string protocol = url.Substring(0, start);
            Console.WriteLine("[protocol] = {0}", protocol);

            string server = url.Substring(start + 3, end - start - 3);
            Console.WriteLine("[server] = {0}", server);

            string resource = url.Substring(end);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }

