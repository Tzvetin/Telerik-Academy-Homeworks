using System;

    class PrintSequence
    {
        static void Main()
        {
            int k = 2;
            for (int i = 0; i < 10; i++, k++)
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine(-k);
                }
        }
    }

