/*
Write a method that checks if the element at given position 
in given array of integers is larger than its two neighbours (when such exist).
*/
using System;

    class LargerThanNeighbours
    {
        static bool BiggerThanNeighbors(int position, int[] array)
        {
            if (position > 0 && position < array.Length - 1)
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("The number has only one neighbour");
            }
            return false;
        }

        static void Main()
        {
            int[] myArray = new int[] { 5, 4, 2, 7, 9, 5, 4, 2, 0, 7, 4, 3 };
            Console.Write("Please enter the position: ");
            int numPosition = int.Parse(Console.ReadLine());
            if (numPosition > myArray.Length || numPosition < 0)
            {
                Console.WriteLine("Position is outside of the array");
                return;
            }
            if (BiggerThanNeighbors(numPosition, myArray))
            {
                Console.WriteLine("the number at position {0} is bigger than its two neighbours", numPosition);
            }
            else
            {
                Console.WriteLine("the number at position {0} is not bigger than its two neighbours", numPosition);
            }
        }
    }

