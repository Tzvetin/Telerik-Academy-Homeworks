using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Write the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write the second number: ");
            double b = double.Parse(Console.ReadLine());
            double bigger = (a > b) ? a : b;
            Console.WriteLine("The greater number is: {0}", bigger);
        }
    }

