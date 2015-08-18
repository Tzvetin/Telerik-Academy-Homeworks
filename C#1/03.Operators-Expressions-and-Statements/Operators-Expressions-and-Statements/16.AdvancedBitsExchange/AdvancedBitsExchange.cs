using System;

    class AdvancedBitsExchange
    {
        static void Main()
        {
            Console.Write("Input n: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Input p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Input q: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());
            bool overlapping = Math.Abs(p - q) < k;
            bool outOfRange = p < 0 | q < 0 | p + (k - 1) > 31 | q + (k - 1) > 31;
            if (outOfRange != true && overlapping != true)
            {
                uint firstBits = (n << (32 - p - k)) >> (32 - k);
                uint secondBits = (n << (32 - q - k)) >> (32 - k);
                n = n & ~(firstBits << p) | secondBits << p;
                n = n & ~(secondBits << q) | firstBits << q;
                Console.WriteLine("Result: {0}", n);
                Console.WriteLine("Binary result: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            }
            else if (outOfRange == true)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                Console.WriteLine("overlapping");
            }
        }
    }

