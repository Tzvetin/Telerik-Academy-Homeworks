using System;

class Trapezoid
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int width = 2 * N;
        int height = N + 1;
        int[,] matrix = new int[height, width];

        int row = 0;
        int col = N; 
        while (col < width)
        {
            matrix[row, col] = 1;
            col++;
        }
        col--;
        while (row < height)
        {
            matrix[row, col] = 1;
            row++;
        }
        row--;
        while (col >= 0)
        {
            matrix[row, col] = 1;
            col--;
        }
        col++;
        while (row >= 0)
        {
            matrix[row, col] = 1;
            row--;
            col++; 
        }

        //output
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (matrix [i, j] == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        } 
        
    }

}