using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Write N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

