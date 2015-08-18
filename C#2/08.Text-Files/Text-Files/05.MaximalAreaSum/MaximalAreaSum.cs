/*
Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
*/
using System;
using System.IO;

    class MaximalAreaSum
    {
        static int SquareWithMaxSum(int[,] matrix)
        {
            int sum = 0;
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine("The matrix is: ");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max sum is {0}", maxSum);

            for (int row = maxRow; row <= maxRow + 1; row++)
            {
                for (int col = maxCol; col <= maxCol + 1; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            return maxSum;
        }

        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\somefile.txt");
            StreamWriter writer = new StreamWriter(@"..\..\output.txt");
            Console.WriteLine("Processing...");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int N = int.Parse(line);
                    Console.WriteLine("Size: {0}", N);
                    line = reader.ReadLine();
                    int[,] myArray = new int[N, N];

                    for (int lineNumber = 0; lineNumber < N; lineNumber++)
                    {
                        string[] splittedStr = line.Split(' ');

                        for (int i = 0; i < N; i++)
                        {
                            myArray[lineNumber, i] = int.Parse(splittedStr[i]);
                        }
                        line = reader.ReadLine();
                    }
                    writer.WriteLine(SquareWithMaxSum(myArray)); 
                }
            }
            
            Console.WriteLine("Done.");
        }
    }

