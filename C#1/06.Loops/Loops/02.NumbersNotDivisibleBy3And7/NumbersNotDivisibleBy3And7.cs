using System;

    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int i = 1;

            while (i <= n)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.WriteLine();
        }
    }

