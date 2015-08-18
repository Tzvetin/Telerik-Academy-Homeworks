using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Please enter the first real number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second real number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third real number: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Please enter the 4th real number: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Please enter the 5th real number: ");
            double e = double.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b > c && b > d && b > e)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c > d && c > e)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else if (d > e)
            {
                Console.WriteLine("The biggest number is: {0}", d);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", e);
            }
        }
    }

