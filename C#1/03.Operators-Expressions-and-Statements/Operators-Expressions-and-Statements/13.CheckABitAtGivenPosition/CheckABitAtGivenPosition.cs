using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Your integer {0} in binary form is:", v);
            Console.WriteLine(Convert.ToString(v, 2).PadLeft(32, '0'));
            Console.Write("Write the bit position to check: ");
            int p = int.Parse(Console.ReadLine());
            bool isOne;
            int mask = (1 << p);
            if ((v & mask) == mask)
            {
                isOne = true;
            }
            else
            {
                isOne = false;
            }
            Console.WriteLine("The bit position {0} is 1: {1}", p, isOne);
        }
    }

