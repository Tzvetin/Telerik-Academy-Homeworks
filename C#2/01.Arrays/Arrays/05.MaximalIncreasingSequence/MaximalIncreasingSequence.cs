//Write a program that finds the maximal increasing sequence in an array.
using System;

    class MaximalIncreasingSequence
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
            int endIndex = 0;
            int count = 1;
            int maxCount = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] < myArray[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        endIndex = i;
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            //last element
            if (count > maxCount)
            {
                maxCount = count;
                endIndex = myArray.Length - 1;
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0} ", myArray[endIndex - maxCount + 1 + i]);
            }
            Console.WriteLine();
        }
    }

