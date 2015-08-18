/*
    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/
using System;

    class SelectionSort
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int start = 0;
            int min = int.MaxValue;
            int minPosition = 0;
            int temp = 0;

            while (start < myArray.Length - 1)
            {
                for (int i = start; i < myArray.Length; i++)
                {
                    if (myArray[i] < min)
                    {
                        min = myArray[i];
                        minPosition = i;
                    }
                }

                temp = myArray[start];
                myArray[start] = min;
                myArray[minPosition] = temp;
                start++;
                min = int.MaxValue;
            }

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                Console.Write("{0} ", myArray[i]);
                Console.WriteLine();
            }
        }
    }

