using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter an integer number < 100 :");
            int r = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (r > 100)
            {
                Console.WriteLine("The number is > 100");
            }
            else if (r < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(r); i++)
                {
                    if (r % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            Console.WriteLine("Is {0} prime? -> {1}", r, isPrime);
        }
    }

