using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter max: ");
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();
            for (int number = 1; number <= n; number++)
            {
                int randomNumber = rand.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }

