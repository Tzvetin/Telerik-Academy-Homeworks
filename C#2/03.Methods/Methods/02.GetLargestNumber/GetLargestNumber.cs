/*
Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/
using System;

    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        static void Main()
        {
            Console.WriteLine("Please enter 3 integers: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int max = GetMax(first, second);
            max = GetMax(max, third);
            Console.WriteLine("The biggest is: {0}", max);
        }
    }

