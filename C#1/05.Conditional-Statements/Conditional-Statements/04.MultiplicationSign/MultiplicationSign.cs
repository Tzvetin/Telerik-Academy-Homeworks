using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Please enter the first real number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second real number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third real number: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("The sign of the product is: ");

            if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("0");
            }
            else if ((a < 0) && (b < 0) && (c < 0))
            {
                Console.WriteLine("-");
            }
            else if ((a > 0) && (b > 0) && (c < 0))
            {
                Console.WriteLine("-");
            }
            else if ((a > 0) && (b < 0) && (c > 0))
            {
                Console.WriteLine("-");
            }
            else if ((a < 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }

