/*
You are given an array of strings. Write a method that sorts the array by the length of its elements 
(the number of characters composing them).
*/
using System;

    class SortByStringLength
    {
        static void Main()
        {
            Console.Write("Enter the number of strings: ");
            int N = int.Parse(Console.ReadLine());
            string[] arrayOfStrings = new string[N];
            int[] lengthOfStrings = new int[N];

            //Fill arrays
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.Write("arrayOfStrings[{0}]: ", i);
                arrayOfStrings[i] = Console.ReadLine();
                lengthOfStrings[i] = arrayOfStrings[i].Length;
            }

            //Sort arrayOfStrings by lengthOfStrings
            Array.Sort(lengthOfStrings, arrayOfStrings);

            //Output
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine("arrayOfStrings[{0}]: {1}", i, arrayOfStrings[i]);
            }
        }
    }

