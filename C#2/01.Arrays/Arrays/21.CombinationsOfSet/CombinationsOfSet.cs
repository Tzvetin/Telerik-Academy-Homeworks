//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
using System;
using System.Collections.Generic;

class AllCombinations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    //generates variations
    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }
    }

    //prints array
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[k];
        Combinations(array, 0, 1);
    }
}

