using System;

    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Your integer in binary form is:");
            Console.WriteLine(Convert.ToString(r, 2).PadLeft(32, '0'));

            int mask = (1 << 3);
            int bit3 = (r & mask) >> 3;
            
            Console.WriteLine("The third bit from the right is {0}", bit3);
        }
    }

