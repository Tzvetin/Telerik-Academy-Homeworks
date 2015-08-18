/*
Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/
using System;

    class SortingArray
    {
        static int MaxElementIndex(int[] arr, int position)
        {
            int max = int.MinValue;
            int maxIndex = 0;
            if (position > arr.Length)
            {
                Console.WriteLine("Position is out of array");
                return -1;
            }
            else
            {
                for (int i = position; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxIndex = i;
                    }
                }
                return maxIndex;
            }
        }

        static int[] SortArray(int[] arr, bool order)
        {
            int[] sortedArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int index = MaxElementIndex(arr, i);
                if (order == true) // descending
                {
                    sortedArr[i] = arr[index];
                }
                else // ascending
                {
                    sortedArr[arr.Length - 1 - i] = arr[index];
                }
                arr[index] = arr[i];
            }
            return sortedArr;
        }

        static void Main()
        {
            int[] myArray = new int[] { 5, 7, 3, 2, 8, 9, 5, 0 };
            Console.Write("Please enter the position: ");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("The max element is: {0}", myArray[MaxElementIndex(myArray, pos)]);
            myArray = SortArray(myArray, false);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }
    }

