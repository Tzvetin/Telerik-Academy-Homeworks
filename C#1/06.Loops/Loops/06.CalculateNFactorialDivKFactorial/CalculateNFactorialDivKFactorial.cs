//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
using System;
using System.Numerics;

    class CalculateNFactorialDivKFactorial
    {
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter k (1<k<n): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }
            Console.WriteLine("n! / k! = {0}", factorialN / factorialK);
        }
    }

