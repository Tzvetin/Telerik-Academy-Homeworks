using System;

    class DivideBy7And5
    {
        static void Main()
        {
            bool dividedBy7And5;
            Console.Write("Write an integer number:");
            int r = int.Parse(Console.ReadLine());
            if ((r % 5 == 0) && (r % 7 == 0))
            {
                dividedBy7And5 = true;
            }
            else
            {
                dividedBy7And5 = false;
            }
            Console.WriteLine("{0} can be divided by 7 and 5? -> {1}", r, dividedBy7And5);
        }
    }

