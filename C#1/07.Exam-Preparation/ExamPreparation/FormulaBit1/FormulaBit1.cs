using System;

class FormulaBit1
{
    static void Main()
        {
            //Input
            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());
                string numToString = Convert.ToString(num, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(numToString[col].ToString());
                }
            }

            //Solution
            int X = 0; //length of the track
            int Y = 0; //count of the turns
            int currentRow = 0;
            int currentCol = 7;
            char dir = 'S';
            char lastDir = 'S';
            bool reached = false;

            while (true)
            {
                if (matrix[currentRow, currentCol] == 1)
                {
                    break;
                }
                X++; 
                if (currentRow == 7 && currentCol == 0)
                 {
                     reached = true;
                     break;
                 }
                //Change dir
                if (dir == 'S' && (currentRow+1 > 7 || matrix[currentRow+1, currentCol] == 1))
                {
                    dir = 'W';
                    Y++;
                    if (currentCol-1 < 0 || matrix[currentRow, currentCol-1] == 1)
                    {
                        break;
                    }
                }
                else if (dir == 'W' && lastDir == 'S' && (currentCol - 1 < 0 || matrix[currentRow, currentCol-1] == 1))
                {
                    dir = 'N';
                    Y++;
                    lastDir = 'N';
                    if (currentRow-1 < 0 || matrix[currentRow-1, currentCol] == 1)
                    {
                        break;
                    }
                }
                else if (dir == 'W' && lastDir == 'N' && (currentCol-1 < 0 || matrix[currentRow, currentCol-1] == 1))
                {
                    dir = 'S';
                    Y++;
                    lastDir = 'S';
                    if (currentRow+1 > 7 || matrix[currentRow+1, currentCol] == 1)
                    {
                        break;
                    }
                }
                else if (dir == 'N' && (currentRow-1 < 0 || matrix[currentRow-1, currentCol] == 1))
                {
                    dir = 'W';
                    Y++;
                    if (currentCol-1 < 0 || matrix[currentRow, currentCol-1] == 1)
                    {
                        break;
                    }
                }
                //Regular move
                if (dir == 'S')
                {
                    currentRow++;
                }
                else if (dir == 'W')
                {
                        currentCol--;
                }
                else if (dir == 'N')
                {
                        currentRow--;
                }
                 
            }
        //Output
       if (reached)
       {
           Console.WriteLine(X + " " + Y);
       }
       else
       {
           Console.WriteLine("No " + X);
       }
    }

}