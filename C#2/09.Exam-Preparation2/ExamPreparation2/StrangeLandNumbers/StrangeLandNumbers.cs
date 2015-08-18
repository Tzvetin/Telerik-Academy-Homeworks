using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

    class StrangeLandNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string partialInput = string.Empty;
            string sevenBase = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];
                string currentDigit = ConvertStrangeLandToNumber(partialInput);

                if (currentDigit != "no")
                {
                    sevenBase += currentDigit;
                    partialInput = string.Empty;
                }
            }
            BigInteger result = 0;

            for (int i = 0; i < sevenBase.Length; i++)
            {
                BigInteger digit = BigInteger.Parse(sevenBase[i].ToString());
                result += digit * PowerOfSeven(sevenBase.Length - i - 1);
            }
            Console.WriteLine(result);
        }

        private static BigInteger PowerOfSeven(int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 7;
            }
            return result;
        }

        private static string ConvertStrangeLandToNumber(string digit)
        {
            string result = "no";

            switch (digit)
            {
                case "f": result = "0"; break;
                case "bIN": result = "1"; break;
                case "oBJEC": result = "2"; break;
                case "mNTRAVL": result = "3"; break;
                case "lPVKNQ": result = "4"; break;
                case "pNWE": result = "5"; break;
                case "hT": result = "6"; break;
                default: break;
            }
            return result;
        }
    }

