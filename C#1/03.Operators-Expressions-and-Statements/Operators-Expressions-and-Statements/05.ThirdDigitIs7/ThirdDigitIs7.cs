using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int r = int.Parse(Console.ReadLine());
            r /= 100;
            r %= 10;
            bool thirdDigitIs7;
            if (r == 7)
            {
                thirdDigitIs7 = true;   
            }
            else
            {
                thirdDigitIs7 = false;
            }
            Console.WriteLine("third digit from right-to-left is 7? -> {0}", thirdDigitIs7);
        }
    }

