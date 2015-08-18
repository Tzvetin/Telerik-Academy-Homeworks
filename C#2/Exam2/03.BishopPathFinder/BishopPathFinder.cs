using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

    class BishopPathFinder
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] dimensionsAsStrings = input.Split(' ');
            int r = int.Parse(dimensionsAsStrings[0]);
            int c = int.Parse(dimensionsAsStrings[1]);

            int[,] chessboard = new int[r, c];

            chessboard = FillChessboard(chessboard, r, c);
            BigInteger globalSum = 0;
            //PrintChessboard(chessboard, r, c);
            int row = r - 1;
            int col = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] directionAndMoves = input.Split(' ');
                string d = directionAndMoves[0];
                int k = int.Parse(directionAndMoves[1]);
                BigInteger sum = 0;

                if (d == "RU" || d == "UR")
                {
                    while (k > 1 && row > 0 && col < c - 1)
                    {
                        row--;
                        col++;
                        sum += chessboard[row, col];
                        chessboard[row, col] = 0;
                        k--;
                        
                    }
                }
                else if (d == "DR" || d == "RD")
                {
                    while (k > 1 && row < r - 1 && col < c - 1)
                    {
                        row++;
                        col++;
                        sum += chessboard[row, col];
                        chessboard[row, col] = 0;
                        k--;
                    }
                }
                else if (d == "DL" || d == "LD")
                {
                    while (k > 1 && row < r - 1 && col > 0)
                    {
                        row++;
                        col--;
                        sum += chessboard[row, col];
                        chessboard[row, col] = 0;
                        k--;
                    }
                }
                else //if (d == "LU" || d == "UL")
                {
                    while (k > 1 && row > 0 && col > 0)
                    {
                        row--;
                        col--;
                        sum += chessboard[row, col];
                        chessboard[row, col] = 0;
                        k--;
                    }
                }

                globalSum += sum;
            }
            Console.WriteLine(globalSum);
        
        }

        static int[,] FillChessboard(int[,] chessboard, int r, int c)
        {
            int initValue = 0;
            for (int row = r - 1; row >= 0; row--)
            {
                int value = initValue;
                for (int col = 0; col < c; col++)
                {
                    chessboard[row, col] = value;
                    value += 3;
                }
                initValue += 3;
            }
            return chessboard;
        }

        static void PrintChessboard(int[,] chessboard, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(chessboard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

