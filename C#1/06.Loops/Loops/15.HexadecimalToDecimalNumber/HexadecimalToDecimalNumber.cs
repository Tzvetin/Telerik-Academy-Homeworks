using System;

    class HexadecimalToDecimalNumber
    {
        static int GetHexaValue(string s, int i)
        {
            switch (s[i])
            {
                case 'A': return 10;
                case 'B': return 11;
                case 'C': return 12;
                case 'D': return 13;
                case 'E': return 14;
                case 'F': return 15;
                default: return s[i] - '0';
            }

        }
        static ulong ConvertToDecimal(string hexa)
        {
            ulong decimalNum = 0;
            ulong power = 1;
            for (int i = hexa.Length - 1; i >= 0; i--, power *= 16)
            {
                decimalNum += (ulong)GetHexaValue(hexa, i) * power;
            }
            return decimalNum;
        }

        static void Main()
        {
            Console.Write("Please enter a hexadecimal number: ");
            string hexaNumber = Console.ReadLine();
            Console.WriteLine(ConvertToDecimal(hexaNumber));
        }
    }

