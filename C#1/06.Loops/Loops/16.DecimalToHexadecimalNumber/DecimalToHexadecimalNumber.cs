using System;

    class DecimalToHexadecimalNumber
    {
        static string ConvertToHexadecimal(long number)
        {
            string hexa = "";
            long remainder = 0;
            while (number != 0)
            {
                remainder = number % 16;
                number = number / 16;
                switch (remainder)
                {
                    case 10: hexa = hexa + "A"; break;
                    case 11: hexa = hexa + "B"; break;
                    case 12: hexa = hexa + "C"; break;
                    case 13: hexa = hexa + "D"; break;
                    case 14: hexa = hexa + "E"; break;
                    case 15: hexa = hexa + "F"; break;
                    default: hexa = hexa + remainder.ToString(); break;
                }
            }
            char[] hexaarray = hexa.ToCharArray();
            Array.Reverse(hexaarray);
            return new string(hexaarray);
        }

        static void Main()
        {
            Console.Write("Please enter the number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            if (decimalNumber > 0)
            {
                Console.WriteLine(ConvertToHexadecimal(decimalNumber));
            }

        }
    }

