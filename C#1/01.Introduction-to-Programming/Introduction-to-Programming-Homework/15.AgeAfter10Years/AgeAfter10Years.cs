using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Write your age and press enter: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is now {0}", r);
            Console.WriteLine("In 10 years you'll be {0}", r + 10);
        }
    }

