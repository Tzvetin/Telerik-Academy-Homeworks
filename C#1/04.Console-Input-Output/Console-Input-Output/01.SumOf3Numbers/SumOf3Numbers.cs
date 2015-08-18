using System;

    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Write the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Write the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Write the third number: ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

