using System;

    class ForestRoad
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int width = N;
            int height = 2 * N - 1;
            bool[,] sign = new bool[width, height];

            for (int i = 0, j = 0; i < N; i++, j++)
            {
                sign[i, j] = true;
            }
            for (int i = N-1, j = N-1; i >=0; i--, j++)
            {
                sign[i, j] = true;
            }

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    if (sign[i, j] == true)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();                
            }

        }
    }

