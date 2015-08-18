using System;

    class Fire
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int width = N;
            int heightFirst=N/2;
            int heightSecond=N/4;
            int heightThird=1;
            int heightFourth=N/2;
            int height = heightFirst+heightSecond+heightThird+heightFourth;
            int[,] matrix = new int[height, width];

                //first part
                int startSharp = width / 2 - 1;
                int rowSharp = 0;
                while (startSharp >= 0) 
                {
                    matrix[rowSharp, startSharp] = 1;
                    matrix[rowSharp, width - startSharp - 1] = 1;
                    startSharp--;
                    rowSharp++;
                }
                
                //second part
                rowSharp = heightFirst;
                startSharp = 0;
                while (rowSharp < heightFirst + heightSecond)
                {
                    matrix[rowSharp, startSharp] = 1;
                    matrix[rowSharp, width - startSharp - 1] = 1;
                    startSharp++;
                    rowSharp++;
                }

                //fourth part
                rowSharp = heightFirst + heightSecond + heightThird;
                startSharp = 0;
                while (rowSharp < height)
                {
                    for (int k = 0; k < width/2; k++)
                    {
                        if (k>=startSharp)
                        {
                            matrix[rowSharp, k] = 3;
                            matrix[rowSharp, width - k - 1] = 2;
                        }
                    }
                    startSharp++;
                    rowSharp++;
                }

                //print
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (matrix[row, col] == 0)
                        {
                            Console.Write('.');
                        }
                        else if (matrix[row, col] == 1)
                        {
                            Console.Write('#');
                        }
                        else if (matrix[row, col] == 2)
                        {
                            Console.Write('/');
                        }
                        else if (matrix[row, col] == 3)
                        {
                            Console.Write('\\');
                        }
                    }
                    Console.WriteLine();

                }

        }
    }

