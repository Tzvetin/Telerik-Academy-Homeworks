//Write a program that finds in given array of integers a sequence of given sum S (if present).
using System;

    class FindSumInArray
    {
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the sum S: ");
            int s = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("myArray[{0}]: ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int start = 0;
            int end = 0;
            int sum = 0;
            int numOfSeq = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (i + j < myArray.Length)
                    {
                        sum += myArray[i + j];
                        if (sum == s)
                        {
                            start = i;
                            end = i + j;
                            numOfSeq++;
                            Console.Write("The sequence {0} is: ", numOfSeq);

                            for (int k = start; k <= end; k++)
                            {
                                Console.Write("{0} ", myArray[k]);
                            }
                            Console.WriteLine();
                        }
                    }

                }
                sum = 0;
            }
            if (numOfSeq == 0)
            {
                Console.WriteLine("No sequences with sum {0}", s);
            }
        }
    }

