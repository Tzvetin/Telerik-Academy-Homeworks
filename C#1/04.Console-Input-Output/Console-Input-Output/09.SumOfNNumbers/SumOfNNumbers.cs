using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Write N: ");
            int N = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.Write("Write number {0}: ", i);
                double temp = double.Parse(Console.ReadLine());
                sum += temp;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

