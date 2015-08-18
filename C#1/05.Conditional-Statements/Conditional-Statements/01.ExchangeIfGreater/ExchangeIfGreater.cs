using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Please enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }

