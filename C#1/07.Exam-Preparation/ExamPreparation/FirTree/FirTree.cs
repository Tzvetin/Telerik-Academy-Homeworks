using System;

    class FirTree
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int W = 1 + (N - 2) * 2;
            
            for (int i = 0; i < N-2; i++)
        {
            string dots = new string('.', (W/2) - 1 - i);
            string stars = new string('*', 1 + 2*i);
            Console.WriteLine("{0}{1}{2}", dots, stars, dots);
        }
            string lastDots = new string('.', (W / 2) - 1);
            string lastStars = new string('*', 1);
            Console.WriteLine("{0}{1}{2}", lastDots, lastStars, lastDots);
        }
    }

