﻿using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n - 1) + new string(':', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(' ', n - 2 - i) + ':' + new string ('/', n - 2) + ':' + new string ('X', i) + ':');
            }

            Console.WriteLine(new string(':', n) +  new string('X', n - 2) + ':');

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(':' + new string(' ', n - 2) + ':' + new string ('X', n - 3 - i) + ':');
            }

            Console.WriteLine(new string(':', n));
        }
    }

