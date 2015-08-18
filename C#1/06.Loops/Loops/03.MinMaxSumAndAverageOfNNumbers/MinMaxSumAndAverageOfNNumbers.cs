using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int countOfNumbers = int.Parse(input);
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                input = Console.ReadLine();
                int n = int.Parse(input);
                sum += n;

                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:F2}", min, max, sum, (double)sum / countOfNumbers);
        }
    }

