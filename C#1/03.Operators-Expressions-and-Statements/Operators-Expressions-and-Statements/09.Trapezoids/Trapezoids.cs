using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Enter the trapezoid side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the trapezoid side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the trapezoid height: ");
            double h = double.Parse(Console.ReadLine());
            double area = h * (a + b) / 2;
            Console.WriteLine("The trapezoid area is: {0}", area);
        }
    }

