//Write a program that finds the sequence of maximal sum in given array.
using System;

    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            //enter array elements
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int startIndex = 0;
            int tempStartIndex = 0;
            int endIndex = 0;
            int currentSum = myArray[0];
            int maxSum = myArray[0];

            //Kadane's algorithm
            //Find start and end index of the sequence of maximal sum in an array.
            //Sum elements one by one until you reach an element, larger than the current sum. That's your start index.
            // Sum elements one by one until their sum is not maximal. That's your end index.
            for (int i = 1; i < myArray.Length; i++)
            {
                currentSum += myArray[i];
                if (myArray[i] > currentSum)
                {
                    currentSum = myArray[i];
                    tempStartIndex = i;
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
        }
    }

