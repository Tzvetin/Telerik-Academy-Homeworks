using System;

    class Carpets
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int startSlash = N / 2 - 1;
            int endSlash = N / 2 - 1;
            bool isSlash = true;
            for (int row = 0; row < N/2; row++)
            {
                for (int col = 0; col < N/2; col++)
                {
                    if (startSlash<=col && col<=endSlash)
                    {
                        if (isSlash == true)
                        {
                            matrix[row, col] = 2;
                            matrix[row, N - col - 1] = 3;
                            matrix[N - row - 1, col] = 3;
                            matrix[N - row - 1, N - col - 1] = 2;
                            isSlash = false;
                        }
                        else
                        {
                            matrix[row, col] = 1;
                            matrix[row, N - col - 1] = 1;
                            matrix[N - row - 1, col] = 1;
                            matrix[N - row - 1, N - col - 1] = 1;
                            isSlash = true;
                        }
                    }
                }
                startSlash--;
                isSlash = true;
            }


            //print
            for (int row = 0; row < N; row++)
			{
                for (int col = 0; col < N; col++)
		        {
                        if (matrix [row, col] == 0)
                        {
                            Console.Write('.');
                        }
                        else if (matrix [row, col] == 1)
                        {
                            Console.Write(' ');
                        }
                        else if (matrix [row, col] == 2)
                        {
                            Console.Write('/');
                        }
                        else if (matrix [row, col] == 3)
                        {
                            Console.Write('\\');
                        }
		        }
                Console.WriteLine();
			 
			}

        }
    }

