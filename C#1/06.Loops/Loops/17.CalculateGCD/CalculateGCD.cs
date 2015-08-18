using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter integer b: ");
            int b = int.Parse(Console.ReadLine());

            int reminder = 0;
            while (b != 0)
            {
                reminder = b;
                b = a % b;
                a = reminder;
            }
            Console.WriteLine(Math.Abs(a));
        }
    }

