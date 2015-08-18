/*
You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/
using System;

    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter the integers separated by space: ");
            string input = Console.ReadLine();
            string[] splittedStr = input.Split(' ');
            int[] myArray = new int[splittedStr.Length];
            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(splittedStr[i]);
                sum += myArray[i];
            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }

