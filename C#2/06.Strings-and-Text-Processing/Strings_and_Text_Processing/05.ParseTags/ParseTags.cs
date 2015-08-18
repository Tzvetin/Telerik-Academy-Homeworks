/*
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
*/
using System;
using System.Text;
using System.Text.RegularExpressions;

  class ParseTags
    {
        static void Main()
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            StringBuilder result = new StringBuilder();
            int counter = 1;
            bool copy = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '<')
                {
                    copy = false;
                    counter++;
                    continue;
                }
                if (str[i] == '>')
                {
                    copy = true;
                    continue;
                }
                if (copy == true && (counter % 2 != 0))
                {
                    result.Append(str[i]);
                }
                if (copy == true && (counter % 2 == 0))
                {
                    result.Append(str[i].ToString().ToUpper());
                }
            }
            Console.WriteLine(result.ToString());
            
            Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }

