/*
Write a program that fills and prints a matrix of size (n, n) as shown below:
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
*/
using System;

    class FillTheMatrixB
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            //Fill
            int currentRow = 0;
            int currentCol = 0;
            string dir = "down";
            int i = 1;
            int limit = N * N;
            while (i <= limit)
            {
                matrix[currentRow, currentCol] = i;
                i++;
                if (dir == "down")
                {
                    currentRow++;
                }
                else if (dir == "up")
                {
                    currentRow--;
                }
                if (currentRow > N - 1)
                {
                    currentRow--;
                    currentCol++;
                    dir = "up";
                }
                if (currentRow < 0)
                {
                    currentRow++;
                    currentCol++;
                    dir = "down";
                }

            }
            //Print
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }

