using System;

    class AngryFemaleGPS
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= -1;
            }
            long sumOdd = 0;
            long sumEven = 0;

            while (number > 0)
            {
                int digit = (int)(number % 10);
                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
                else
                {
                    sumEven += digit;
                }
                number /= 10;
            }
            if (sumOdd > sumEven)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else if (sumOdd < sumEven)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else
            {
                Console.WriteLine("straight {0}", sumEven);
            }
        }
    }

