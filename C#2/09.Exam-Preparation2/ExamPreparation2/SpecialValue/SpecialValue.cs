using System;

    class SpecialValue
    {
        static int[][] ReadData(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currentLine = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                field[i] = new int[currentLine.Length];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    field[i][j] = int.Parse(currentLine[j]);
                }
            }
            return field;
        }

        static long FindCurrentSpecialValue (int[][]field, int column, bool[][] visited)
        {
            long result = 0;
            int currentRow = 0;
            while (true)
            {
                result++;
                
                if (visited[currentRow][column])
                {
                    return long.MinValue;
                }
                if (field[currentRow][column] < 0)
                {
                    result -= field[currentRow][column];
                    return result;
                }
                int nextColumn = field[currentRow][column];
                visited[currentRow][column] = true;
                column = nextColumn;
                currentRow++;
                if(currentRow == field.GetLength(0))
                {
                    currentRow = 0;
                }
            }
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[][] field = new int[N][];
            ReadData(field);
            bool[][] visited = new bool[N][];
            for (int i = 0; i < N; i++)
            {
                visited[i] = new bool[field[i].Length];
            }
            long max = long.MinValue;

            for (int i = 0; i < field[0].Length; i++)
            {
                long specialValue = FindCurrentSpecialValue(field, i, visited);
                if (max < specialValue)
                {
                    max = specialValue;
                }
            }
            Console.WriteLine(max);
        }
    }

