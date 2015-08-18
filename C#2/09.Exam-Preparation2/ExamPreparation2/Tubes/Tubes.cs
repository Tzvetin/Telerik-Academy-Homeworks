using System;

    class Tubes
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long M = long.Parse(Console.ReadLine());
            long[] tubesSizes = new long[N];
            long maxTube = 0;
            for (int i = 0; i < N; i++)
            {
                tubesSizes[i] = long.Parse(Console.ReadLine());
                if (maxTube < tubesSizes[i])
                {
                    maxTube = tubesSizes[i];
                }
            }
            long left = 1;
            long right = maxTube;
            long middle = (left + right)/2;
            long finalResult = -1;

            while (left <= right)
            {
                long eventual = 0;
                for (int j = 0; j < tubesSizes.Length; j++)
                {
                    eventual += tubesSizes[j] / middle;
                }
                if (eventual < M)
                {
                    right = middle - 1;
                }
                else if (eventual >= M)
                {
                    left = middle + 1;
                    finalResult = middle;
                }
                middle = (left + right) / 2; 
                
            }
            Console.WriteLine(finalResult);
        }
    }

