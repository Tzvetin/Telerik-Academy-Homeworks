//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;

    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number that we are searching for: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int startIndex = 0;
            int endIndex = myArray.Length - 1;
            int middle;
            bool isFound = false;

            Array.Sort(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("myArray[{0}]: {1}", i, myArray[i]);
            }

            while (startIndex <= endIndex)
            {
                middle = (startIndex + endIndex) / 2;
                if (myArray[middle] == searchedNumber)
                {
                    Console.WriteLine("The number {0} is with index [{1}]", searchedNumber, middle);
                    isFound = true;
                    break;
                }
                if (myArray[middle] > searchedNumber)
                {
                    endIndex = middle - 1;
                }
                if (myArray[middle] < searchedNumber)
                {
                    startIndex = middle + 1;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("No number {0} in the array", searchedNumber);
            }
        }
    }

