/*
    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
*/
using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum S: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("myArray[{0}]: ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }

        int numOfSubsets = 0;

        int maxSubsets = (int)Math.Pow(2, n) - 1;

        for (int i = 1; i <= maxSubsets; i++)
        {
            string subset = "";
            int sumToCheck = 0;
            int numberOfElements = 0;
            for (int bitToTake = 0; bitToTake < n; bitToTake++)
            {
                int mask = 1 << bitToTake;
                int nAndMask = i & mask;
                int bit = nAndMask >> bitToTake;
                if (bit == 1)
                {
                    sumToCheck += myArray[bitToTake];
                    subset = subset + " " + myArray[bitToTake];
                    numberOfElements++;
                }
            }
            if (sumToCheck == s && numberOfElements == k)
            {
                numOfSubsets++;
                Console.WriteLine("Subset {0}: {1}", numOfSubsets, subset);

            }
        }
    }
}
