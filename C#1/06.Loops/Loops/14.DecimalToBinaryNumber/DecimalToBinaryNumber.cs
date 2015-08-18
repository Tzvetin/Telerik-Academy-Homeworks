using System;

    class DecimalToBinaryNumber
    {
        static string ConvertToBinary(long number)
        {
            string binary = "";
            long remainder = 0;
            
            while (number != 0)
            {
                remainder = number % 2;
                number = number / 2;
                binary = binary + remainder.ToString();
            }
            char[] binaryarray = binary.ToCharArray();
            Array.Reverse(binaryarray);
            return new string(binaryarray);

        }
        static void Main()
        {
            Console.Write("Please enter the decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            if (decimalNumber > 0)
            {
                Console.WriteLine(ConvertToBinary(decimalNumber));
            }

        }
    }

