/*
Write a program that fills and prints a matrix of size (n, n) as shown below:
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
*/
using System;

    class FillTheMatrixD
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
                //move to next position
                if (dir == "down")
                {
                    currentRow++;
                }
                else if (dir == "up")
                {
                    currentRow--;
                }
                else if (dir == "left")
                {
                    currentCol--;
                }
                else if (dir == "right")
                {
                    currentCol++;
                }
                //check if out of matrix or on already visited position
                if (dir == "down" && (currentRow > N - 1 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    dir = "right";
                    currentCol++;
                }
                if (dir == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    dir = "left";
                    currentCol--;
                }
                if (dir == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    dir = "down";
                    currentRow++;
                }
                if (dir == "right" && (currentCol > N - 1 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    dir = "up";
                    currentRow--;
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

