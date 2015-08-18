using System;

    class NumbersInIntervalDividable
    {
        static void Main()
        {
            Console.Write("Please enter the start integer: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Please enter the end integer: ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine("The count of numbers p is: {0}", p);
        }
    }

