//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        bool[] primeNumbers = new bool[n];
        int limit = (int)Math.Sqrt(n);

        for (int i = 2; i <= limit; i++)
        {
            if (primeNumbers[i] == false)
            {
                for (int j = i * i; j < n; j += i)
                {
                    primeNumbers[j] = true;
                }
            }
        }
        for (int i = 2; i < n; i++)
        {
            if (primeNumbers[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
