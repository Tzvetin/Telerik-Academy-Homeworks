using System;

    class Sheets
    {
        static void Main()
        {
            //Variant 1
            /*int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int bitToTake = i;
                int mask = 1 << bitToTake;
                int numberAndMask = N & mask;
                int bit = numberAndMask >> bitToTake;

                if (bit == 0)
                {
                    Console.WriteLine("A" + (10 - i));
                }
            }*/

            //Variant 2
            int N = int.Parse(Console.ReadLine());
            int[] sheetsValue = new int[11] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

            for (int i = 0; i < sheetsValue.Length; i++)
            {
                if (N <= sheetsValue[i])
                {
                    Console.WriteLine("A" + i);
                }
                else
                {
                    N -= sheetsValue[i];
                }
            }

        }
    }

