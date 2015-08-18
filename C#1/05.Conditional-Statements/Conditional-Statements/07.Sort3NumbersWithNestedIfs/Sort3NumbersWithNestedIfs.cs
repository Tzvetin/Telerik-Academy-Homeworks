using System;

    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.Write("Please enter the first real number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second real number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third real number: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("The order is: {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("The order is: {0} {1} {2}", a, c, b);
                }

            }
            else
            {
                if (b > c)
                {
                    if (c > a)
                    {
                        Console.WriteLine("The order is: {0} {1} {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("The order is: {0} {1} {2}", b, a, c);
                    }
                }
                else
                {
                    if (b > a)
                    {
                        Console.WriteLine("The order is: {0} {1} {2}", c, b, a);
                    }
                    else
                    {
                        Console.WriteLine("The order is: {0} {1} {2}", c, a, b);
                    }
                }
            }
        }
    }

