//Write a program that reads two integer arrays from the console and compares them element by element.
using System;

    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter the length of the first array: ");
            int firstArrayLength = int.Parse(Console.ReadLine());
            Console.Write("Enter the length of the second array: ");
            int secondArrayLength = int.Parse(Console.ReadLine());
            if (firstArrayLength != secondArrayLength)
            {
                Console.WriteLine("The size is different");
            }
            else
            {
                bool areEqual = true;
                int[] firstArray = new int[firstArrayLength];
                int[] secondArray = new int[secondArrayLength];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write("firstArray[{0}]: ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < secondArray.Length; j++)
                {
                    Console.Write("secondArray[{0}]: ", j);
                    secondArray[j] = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < firstArray.Length; k++)
                {
                    if (firstArray[k] != secondArray[k])
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (areEqual)
                {
                    Console.WriteLine("The arrays are equal");
                }
                else
                {
                    Console.WriteLine("The arrays are different");
                }

            }
        }
    }

