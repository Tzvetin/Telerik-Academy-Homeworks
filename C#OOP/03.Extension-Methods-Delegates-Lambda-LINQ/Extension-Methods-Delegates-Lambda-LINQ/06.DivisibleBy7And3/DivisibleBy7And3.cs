//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main(string[] args)
        {
            var integers = new int[] {3, 7, 20, 21, 70, 12, 42};
            Console.WriteLine("extension methods and lambda expressions:");
            var result = integers.Where(x => (x % 3 == 0 && x % 7 == 0)).ToArray<int>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("LINQ");
            var linqResult =
                from num in integers
                where (num % 3 == 0 && num % 7 == 0)
                select num;
            foreach (var item in linqResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
