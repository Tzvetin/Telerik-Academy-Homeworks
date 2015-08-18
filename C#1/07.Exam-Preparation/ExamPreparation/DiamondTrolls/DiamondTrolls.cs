using System;

    class DiamondTrolls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = n * 2 + 1;
            int height = 6 + ( (n-3) / 2 ) * 3;
            bool[,] diamond = new bool[height, width];
            // |
            int currentRow = 0;
            int currentCol = width / 2;
            for (int i = 0; i < height; i++)
            {
                diamond[currentRow + i, currentCol] = true;
            }
            //diamond head
            currentCol = (width - n) / 2;
            for (int i = 0; i < n; i++)
            {
                diamond[currentRow, currentCol + i] = true;
            }
            // /
            while(currentCol >= 0)
            {
                diamond[currentRow, currentCol] = true;
                ++currentRow;
                --currentCol;
            }
            --currentRow;
            ++currentCol;
            // _
            for (int i = 0; i < width; i++)
            {
                diamond[currentRow, currentCol + i] = true;
            }
            // \
            while(currentRow < height)
            {
                diamond[currentRow, currentCol] = true;
                ++currentRow;
                ++currentCol;
            }
            --currentRow;
            --currentCol;
            // /
            while(currentCol < width)
            {
                diamond[currentRow, currentCol] = true;
                --currentRow;
                ++currentCol;
            }
            ++currentRow;
            --currentCol;
            // \
            while (currentRow >= 0)
            {
                diamond[currentRow, currentCol] = true;
                --currentRow;
                --currentCol;
            }
           


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (diamond[i, j] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
                
            }
        }
    }

