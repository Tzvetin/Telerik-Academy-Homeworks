using System;

    class TelerikLogo
    {
        static void Main()
        {
            //Input
            int X = int.Parse(Console.ReadLine());
            int Y = X;
            int Z = (X / 2) + 1;
            int N = Z + Y + Y + Z - 3;
            int[,] matrix = new int[N, N];

            //Solution
            int currentRow = Z-1;
            int currentCol = 0;
            string dir = "NE";

            while (true)
            {
                matrix[currentRow, currentCol] = 1;
                if (currentRow == Z - 1 && currentCol == N - 1)
                {
                    break;
                }
                //Change Dir
                if (dir == "NE" && currentRow == 0)
                {
                    dir = "SE";
                }
                else if (dir == "SE" && currentCol == N-Z)
                {
                    dir = "SW";
                }
                else if (dir == "SW" && currentRow == N-1)
                {
                    dir = "NW";
                }
                else if (dir == "NW" && currentCol == Z-1)
                {
                    dir = "NE";
                }
                //Regular move
                if (dir == "NE")
                {
                    currentRow--;
                    currentCol++;
                }
                else if (dir == "SE")
                {
                    currentRow++;
                    currentCol++;
                }
                else if (dir == "SW")
                {
                    currentRow++;
                    currentCol--;
                }
                else if (dir == "NW")
                {
                    currentRow--;
                    currentCol--;
                }
            
            }

            //Output
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();

            }
        }
    }

