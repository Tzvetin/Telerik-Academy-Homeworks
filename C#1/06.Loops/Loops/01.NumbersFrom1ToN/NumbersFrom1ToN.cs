using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int i = 1;

            while (i <= n)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
        }
    }

