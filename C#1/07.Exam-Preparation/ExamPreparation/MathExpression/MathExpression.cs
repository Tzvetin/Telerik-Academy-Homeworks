using System;

    class MathExpression
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());

            double numerator = (N * N) + (1/(double)(M * P)) + 1337;
            double denominator = N - (128.523123123 * P);
            double result = (numerator / (double)denominator) + Math.Sin(Math.Truncate(M) % 180);
            Console.WriteLine("{0:F6}", result);
        }
    }

