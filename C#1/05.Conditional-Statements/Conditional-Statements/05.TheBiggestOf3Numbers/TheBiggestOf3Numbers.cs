using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("Please enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} is the biggest number", a);
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("{0} is the biggest number", b);
                }
                else
                {
                    Console.WriteLine("{0} is the biggest number", c);
                }
            }
        }
    }

