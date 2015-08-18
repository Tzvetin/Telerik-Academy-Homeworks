using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            if(number < 0)
            {
                number *= -1;
            }
            int position = 1;
            BigInteger specialSum = 0;
            BigInteger numberBackup = number;

            while (number > 0)
            {
                int currentDigit = (int)(number % 10);
                if (position % 2 != 0)
                {
                    specialSum += currentDigit * position * position;
                }
                else
                {
                    specialSum += currentDigit * currentDigit * position;
                }
                ++position;
                number /= 10;
            }
            Console.WriteLine("{0}", specialSum);
            int r = (int)(specialSum % 26);
            int sequenceLength = (int)(specialSum % 10);
            if(sequenceLength == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", numberBackup);
            }
            else
            {
                for (int i = 0; i < sequenceLength; i++)
                {
                    Console.Write((char)('A' + (r + i) % 26));
                }
                Console.WriteLine();
            }
        }
    }

