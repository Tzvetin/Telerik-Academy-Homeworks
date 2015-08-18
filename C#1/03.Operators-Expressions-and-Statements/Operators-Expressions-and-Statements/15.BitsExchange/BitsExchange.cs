using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Please enter a 32-bit unsigned integer: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation of n: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            uint first3Bits = (n >> 3) & 7; 
            uint second3Bits = (n >> 24) & 7;
            uint maskFirst3Bits = 7 << 3;
            uint maskSecond3Bits = 7 << 24;
            n = n & ~maskFirst3Bits | (second3Bits << 3);
            n = n & ~maskSecond3Bits | (first3Bits << 24);
            Console.WriteLine("Result: {0}", n);
            Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }

