/*
Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/
using System;

    class FirstLargerThanNeighbours
    {
        static int BiggerThanNeighbors(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            int[] myArray = new int[] { 5, 4, 2, 7, 9, 5, 4, 2, 0, 7, 4, 3 };
            int result = BiggerThanNeighbors(myArray);
            if (result == -1)
            {
                Console.WriteLine("There is no element bigger than its two neighbors");
            }
            else
            {
                Console.WriteLine("The first number bigger than its two neighbors is at position {0}", result);
            }
        }
    }
