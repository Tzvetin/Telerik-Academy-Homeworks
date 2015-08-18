//Write a program to calculate the n-th Catalan number by given n (1 <= n <= 100). 
using System;
using System.Numerics;

    class CatalanNumbers
    {
        static BigInteger Factorial(int n)
        {
            BigInteger nFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }
            return nFact;
        }

        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The n-th Catalan number is: {0}", Factorial(2*n) / (Factorial(n+1) * Factorial(n)));
        }
    }

