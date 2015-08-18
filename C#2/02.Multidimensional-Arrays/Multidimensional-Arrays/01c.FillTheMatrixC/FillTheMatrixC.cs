/*
Write a program that fills and prints a matrix of size (n, n) as shown below:
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
*/
using System;

    class FillTheMatrixC
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            //Fill
            int currentRow = N - 1;
            int currentCol = 0;
            int lastStart = N - 1;
            string dir = "firstHalf";
            int i = 1;
            int limit = N * N;

            while (i <= limit)
            {
                matrix[currentRow, currentCol] = i;
                i++;
                currentRow++;
                currentCol++;

                if (dir == "firstHalf" && currentRow > N - 1)
                {
                    currentRow = --lastStart;
                    currentCol = 0;
                }
                if (dir == "secondHalf" && currentCol > N - 1)
                {
                    currentRow = 0;
                    currentCol = ++lastStart;
                }
                if (i == limit / 2)
                {
                    dir = "secondHalf";
                    lastStart = 0;
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

