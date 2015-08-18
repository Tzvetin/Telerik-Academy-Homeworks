/*
Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, 
indexer for accessing the matrix content and ToString().
*/
using System;

    class Program
    {
        static void Main()
        {
            Matrix m1 = new Matrix(3, 3);
            Matrix m2 = new Matrix(3, 3);
            // Fill with random numbers
            Random randomGenerator = new Random();
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    m1[i, j] = randomGenerator.Next(20);
                    m2[i, j] = randomGenerator.Next(20);
                }
            }
            Console.WriteLine("Matrix 1");
            Console.WriteLine(m1);
            Console.WriteLine("Matrix 2");
            Console.WriteLine(m2);
            Console.WriteLine("Matrix 1 + Matrix 2");
            Console.WriteLine(m1 + m2);
            Console.WriteLine("Matrix 1 - Matrix 2");
            Console.WriteLine(m1 - m2);
            Console.WriteLine("Matrix 1 * Matrix 2");
            Console.WriteLine(m1 * m2);
        }
    }

