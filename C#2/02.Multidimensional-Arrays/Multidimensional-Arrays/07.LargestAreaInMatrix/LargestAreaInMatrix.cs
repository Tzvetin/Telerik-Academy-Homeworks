//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.


using System;

class LargestSet
{
    static int[,] matrix = { { 1, 3, 2, 2, 2, 4 }, 
                             { 2, 3, 3, 2, 4, 4 }, 
                             { 4, 3, 1, 2, 3, 3 }, 
                             { 4, 3, 1, 3, 3, 1 }, 
                             { 4, 3, 3, 3, 1, 1 } };

    static bool[,] visited = new bool[5, 6];

    static bool IsInRange(int row, int col)
    {
        bool inRange = true;
        if ((row < 0) || (row >= 5))
        {
            inRange = false;
        }
        if ((col < 0) || (col >= 6))
        {
            inRange = false;
        }
        if (inRange == true)
        {
            if (visited[row, col] == true)
            {
                inRange = false;
            }
        }
        return inRange;
    }

    static int GetCount(int row, int col, int value)
    {
        int count = 0;

        if (IsInRange(row, col) == false)
        {
            return count;
        }
        else
        {
            if (matrix[row, col] == value)
            {
                count++;

                visited[row, col] = true;

                count += GetCount(row - 1, col - 1, value);
                count += GetCount(row - 1, col, value);
                count += GetCount(row - 1, col + 1, value);

                count += GetCount(row, col - 1, value);
                count += GetCount(row, col + 1, value);

                count += GetCount(row + 1, col - 1, value);
                count += GetCount(row + 1, col, value);
                count += GetCount(row + 1, col + 1, value);
            }
        }

        return count;
    }

    static void Main()
    {
        int setCount = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                int newCount = GetCount(i, j, matrix[i, j]);

                if (newCount > setCount)
                {
                    setCount = newCount;
                }
            }
        }

        Console.WriteLine(setCount);
    }
}

