/*
 We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements 
 * located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */
using System;

    class SequenceNMatrix
    {
        static void Main()
        {
            string[,] matrix = new string[,] { { "ha", "fifi", "ho", "hi" }, 
                                                { "fo", "ha", "hi", "xx" }, 
                                                { "xxx", "ho", "ha", "xx" } };
            int currentSeq = 1;
            int maxSeq = 1;
            string maxString = "";

            //Horizontal
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxString = matrix[row, col];
                    }
                }
                currentSeq = 1;
            }

            //Vertical
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        maxString = matrix[row, col];
                    }
                }
                currentSeq = 1;
            }

            //Diagonal 1
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    for (int currentRow = row, currentCol = col;
                    currentRow < matrix.GetLength(0) - 1 && currentCol < matrix.GetLength(1) - 1;
                    currentRow++, currentCol++)
                    {
                        if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol + 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }
                        if (currentSeq > maxSeq)
                        {
                            maxSeq = currentSeq;
                            maxString = matrix[currentRow, currentCol];
                        }
                    }
                    currentSeq = 1;
                }
            }

            //Diagonal 2
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    for (int currentRow = row, currentCol = col;
                    currentRow < matrix.GetLength(0) - 1 && currentCol > 0;
                    currentRow++, currentCol--)
                    {
                        if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol - 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }
                        if (currentSeq > maxSeq)
                        {
                            maxSeq = currentSeq;
                            maxString = matrix[currentRow, currentCol];
                        }
                    }
                    currentSeq = 1;
                }
            }

            Console.WriteLine("Max lenght = {0}, String = {1}", maxSeq, maxString);
        }
    }

