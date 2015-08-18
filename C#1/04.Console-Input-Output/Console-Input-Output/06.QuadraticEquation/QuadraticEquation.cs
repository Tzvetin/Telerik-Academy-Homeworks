using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Write a: ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a cannot be zero");
            }
            else
            {
                Console.Write("Write b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Write c: ");
                double c = double.Parse(Console.ReadLine());
                double D = (b * b) - (4 * a * c);
                //Console.WriteLine("D={0}", D);
                if (D < 0)
                {
                    Console.WriteLine("There is no real solution");
                }
                    
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("There is only one real solution x1 = x2 = {0}", x);
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("There are two real solutions x1 = {0}, x2 = {1}", x1, x2);
                }

            }
        }
    }

