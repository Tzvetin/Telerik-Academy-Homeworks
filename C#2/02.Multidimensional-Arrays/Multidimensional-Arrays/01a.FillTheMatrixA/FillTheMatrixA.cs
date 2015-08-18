/*
Write a program that fills and prints a matrix of size (n, n) as shown below:
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
*/
using System;

    class FillTheMatrixA
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            //Fill
            int i = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = i;
                    i++;
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

