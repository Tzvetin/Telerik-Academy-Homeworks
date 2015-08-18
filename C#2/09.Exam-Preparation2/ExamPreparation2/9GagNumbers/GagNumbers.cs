using System;
using System.Numerics;

    class GagNumbers
    {
        static string ConvertGagStringToNumber(string digit)
        {
            string result = "no";
            switch (digit)
            {
                case "-!": result = "0"; break;
                case "**": result = "1"; break;
                case "!!!": result = "2"; break;
                case "&&": result = "3"; break;
                case "&-": result = "4"; break;
                case "!-": result = "5"; break;
                case "*!!!": result = "6"; break;
                case "&*!": result = "7"; break;
                case "!!**!-": result = "8"; break;
                default: break;
            }
            return result;
        }
        static BigInteger PowerOfNine(int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
                {
                    result *= 9;
                }
            return result;
        }
        static void Main()
        {
            string input = Console.ReadLine();
            string partialInput = string.Empty;
            string nineBase = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];
                string currentDigit = ConvertGagStringToNumber(partialInput);
                if (currentDigit != "no")
                {
                    nineBase += currentDigit;
                    partialInput = string.Empty;
                }

            }
     //       Console.WriteLine(nineBase);
            BigInteger result = 0;
            for (int i = 0; i < nineBase.Length; i++)
            {
                BigInteger digit = BigInteger.Parse(nineBase[i].ToString());
                result += digit * PowerOfNine(nineBase.Length - i - 1);
            }
            Console.WriteLine(result);
        }
    }

