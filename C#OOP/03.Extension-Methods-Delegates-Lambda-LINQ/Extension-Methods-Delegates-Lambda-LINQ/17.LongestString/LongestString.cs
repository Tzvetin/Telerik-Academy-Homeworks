//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            var array = new string[] { "Natalia", "Rumen", "Lubo", "Vanya", "Lora" };
            string maxLength = array.OrderByDescending(x => x.Length).First();
            Console.WriteLine("The string with max length is: " + maxLength);
            var result =
                (from names in array
                orderby names.Length descending
                select names).First();
            Console.WriteLine("The string with max length is: " + result);

        }
    }
}
