﻿using System;
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r = 0;
            if (b == 3)
            {
                r = a + c;
            }
            if (b == 6)
            {
                r = a * c;
            }
            if (b == 9)
            {
                r = a % c;
            }
            if (r % 3 == 0)
            {
                Console.WriteLine(r / 3);
            }
            else
            {
                Console.WriteLine(r % 3);
            }
            Console.WriteLine(r);
        }
    }

