using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Please enter a four-digit number: ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = (number / 1000) % 10;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;
            Console.WriteLine("sum of digits: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("reversed: {0}", fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit);
            Console.WriteLine("last digit in front: {0}", fourthDigit * 1000 + firstDigit * 100 + secondDigit * 10 + thirdDigit);
            Console.WriteLine("second and third digits exchanged: {0}", firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit);
        }
    }

