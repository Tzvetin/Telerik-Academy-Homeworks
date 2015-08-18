//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

    class CompareCharArrays
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
                char[] firstArray = new char[firstArrayLength];
                char[] secondArray = new char[secondArrayLength];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write("firstArray[{0}]: ", i);
                    firstArray[i] = char.Parse(Console.ReadLine());
                }
                for (int j = 0; j < secondArray.Length; j++)
                {
                    Console.Write("secondArray[{0}]: ", j);
                    secondArray[j] = char.Parse(Console.ReadLine());
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

