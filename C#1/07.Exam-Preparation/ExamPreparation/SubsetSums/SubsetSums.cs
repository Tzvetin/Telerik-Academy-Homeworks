using System;

    class SubsetSums
    {
        static void Main()
        {
            long s = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            long combinations = 1;// (long)Math.Pow((double)2, n) - 1;
            for (int i = 1; i <= n; i++)
            {
                combinations *= 2;
            }
            combinations -= 1;
            int count = 0;
            for (int i = 1; i <= combinations; i++)
            {
                long currentSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        currentSum += numbers[j];
                    }
                }
                if (currentSum == s)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

