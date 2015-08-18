using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", 1 + i + j);
                }
                Console.WriteLine();
            }
        }
    }

