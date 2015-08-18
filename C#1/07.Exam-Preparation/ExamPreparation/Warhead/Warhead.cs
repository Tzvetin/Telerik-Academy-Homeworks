using System;


public class Program
{
    public static void Main()
    {
        const int numberOfLines = 16;
        char[,] matrix = new char[16, 16];

        int blueCapacitors = 0;
        int redCapacitors = 0;
        char redCenterCapacitor = 'R';
        char blueCenterCapacitor = 'B';

        for (int row = 0; row < numberOfLines; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < line.Length; col++)
            {
                char digit = line[col];
                matrix[row, col] = digit;
            }
        }

        // counting capacitors
        for (int row = 1; row < numberOfLines - 1; row++)
        {
            for (int col = 1; col < numberOfLines - 1; col++)
            {
                if (matrix[row, col] == '0')
                {
                    int capacitorParts = 0;

                    if (
                        matrix[row - 1, col - 1] == '1' &&
                        matrix[row - 1, col] == '1' &&
                        matrix[row - 1, col + 1] == '1' &&
                        matrix[row, col - 1] == '1' &&
                        matrix[row, col + 1] == '1' &&
                        matrix[row + 1, col - 1] == '1' &&
                        matrix[row + 1, col] == '1' &&
                        matrix[row + 1, col + 1] == '1'
                        )
                    {
                        capacitorParts = 8;
                    }

                    if (capacitorParts == 8 && col < numberOfLines / 2)
                    {
                        redCapacitors++;
                        matrix[row, col] = redCenterCapacitor;
                        if (redCapacitors == 6)
                        {
                            redCapacitors--;
                        }
                    }

                    else if (capacitorParts == 8 && col >= numberOfLines / 2)
                    {
                        blueCapacitors++;
                        matrix[row, col] = blueCenterCapacitor;
                    }
                }

            }
        }

        while (true)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "hover":
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());

                    if (matrix[row, col] == '1')
                    {
                        Console.WriteLine("*");
                    }

                    else
                    {
                        Console.WriteLine("-");
                    }
                    break;


                case "operate":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());

                    if (matrix[row, col] == '1')
                    {
                        Console.WriteLine("missed");
                        Console.WriteLine(redCapacitors + blueCapacitors);
                        Console.WriteLine("BOOM");
                        return;
                    }

                    if (matrix[row, col] == 'R')
                    {
                        redCapacitors--;

                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                matrix[i, j] = '0';
                            }
                        }
                    }

                    if (matrix[row, col] == 'B')
                    {
                        blueCapacitors--;

                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                matrix[i, j] = '0';
                            }
                        }
                    }
                    break;

                case "cut":
                    command = Console.ReadLine();
                    if (command == "red")
                    {
                        if (redCapacitors == 0)
                        {
                            Console.WriteLine(blueCapacitors);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(redCapacitors);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }

                    else
                    {
                        if (blueCapacitors == 0)
                        {
                            Console.WriteLine(redCapacitors);
                            Console.WriteLine("disarmed");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(blueCapacitors);
                            Console.WriteLine("BOOM");
                            return;
                        }
                    }
            }
        }
    }
}
