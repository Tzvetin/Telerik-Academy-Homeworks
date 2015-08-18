/*
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/
using System;

class AppearanceCount
{
    static int NumberAppearences(int number, int[] array)
    {
        int appearences = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                appearences++;
            }
        }
        return appearences;
    }
    static void Main()
    {
        int[] myArray = new int[] { 0, 1, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 6, 7, 8, 8, 9 };
        Console.Write("Please enter a digit: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The digit {0} appears {1} times in the array", n, NumberAppearences(n, myArray));
    }

}