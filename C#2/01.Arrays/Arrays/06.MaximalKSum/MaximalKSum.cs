/*
    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
*/
using System;

    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(myArray);

            int sum = 0;

            for (int j = myArray.Length - 1; j > myArray.Length - 1 - k; j--)
            {
                sum += myArray[j];
            }

            Console.WriteLine("The max sum of {0} elements is: {1}", k, sum);
        }
    }

