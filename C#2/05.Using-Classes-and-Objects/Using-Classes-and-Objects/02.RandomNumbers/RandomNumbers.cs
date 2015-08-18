// Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;

class RandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();
            for (int number = 1; number <= 10; number++)
            {
                int randomNumber = rand.Next(100, 201);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }
