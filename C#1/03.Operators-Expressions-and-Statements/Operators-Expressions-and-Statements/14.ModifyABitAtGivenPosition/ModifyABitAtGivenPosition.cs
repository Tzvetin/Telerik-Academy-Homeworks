using System;

    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your integer {0} in binary form is:", n);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.Write("Enter the bit position to change: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Write the new value (0 or 1)");
            byte v = byte.Parse(Console.ReadLine());

            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine("The result is: {0}", result);
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }
            else //v == 1
            {
                int mask = (1 << p);
                int result = n | mask;
                Console.WriteLine("The result is: {0}", result);
                Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            }
        }
    }

