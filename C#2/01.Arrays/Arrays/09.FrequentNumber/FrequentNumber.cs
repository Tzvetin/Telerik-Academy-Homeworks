//Write a program that finds the most frequent number in an array.
using System;

    class FrequentNumber
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

            Array.Sort(myArray);

            int frequentNumber = myArray[0];
            int count = 1;
            int maxCount = 1;

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] == myArray[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        frequentNumber = myArray[i - 1];
                    }
                    count = 1;
                }
            }
            //special case:
            if (count > maxCount)
            {
                maxCount = count;
                frequentNumber = myArray[myArray.Length - 1];
            }
            Console.WriteLine("Most frequent number: {0} ({1} times)", frequentNumber, maxCount);
        }
    }

