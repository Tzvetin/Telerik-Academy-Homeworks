/*
Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */
using System;

    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];

            //Fill
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //Sort array
            Array.Sort(myArray);

            foreach (var element in myArray)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            //Binary search
            int elementIndex = Array.BinarySearch(myArray, K);

            while (elementIndex < 0)
            {
                if (K < myArray[0])
                {
                    break;
                }
                K--;
                elementIndex = Array.BinarySearch(myArray, K);
            }

            //Output
            if (elementIndex < 0)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine("Element <= {0} found at index [{1}] = {2}", K, elementIndex, myArray[elementIndex]);
            }
        }
    }

