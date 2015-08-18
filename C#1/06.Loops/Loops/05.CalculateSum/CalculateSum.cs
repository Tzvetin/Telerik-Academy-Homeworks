//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n
using System;

    class CalculateSum
    {
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter x: ");
            int x = int.Parse(Console.ReadLine());
            decimal factorialN = 1;
            decimal dividerX = 1;
            decimal sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
                dividerX = dividerX * x;
                sum = sum + (factorialN / dividerX);
            }
            Console.WriteLine("The sum 1 + 1!/X + 2!/X^2 + … + N!/X^N is: {0:F5}", sum);
        }
    }

