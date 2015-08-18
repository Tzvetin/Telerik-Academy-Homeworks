using System;

    class OddOrEvenIntegers
    {
        static void CheckIfOdd(int n)
        {
            bool isOdd;
            if (n % 2 != 0)
            {
                isOdd = true;
            }
            else
            {
                isOdd = false;
            }
            Console.WriteLine("Is {0} odd? -> {1}", n, isOdd);
        }

        static void Main()
        {
            CheckIfOdd(3);
            CheckIfOdd(2);
            CheckIfOdd(-2);
            CheckIfOdd(-1);
            CheckIfOdd(0);
        }
    }

