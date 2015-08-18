using System;
using System.Numerics;

    class Program
    {
        static string transformation(string input)
        {
            string inputString = input;
            BigInteger product = 1;

            while (inputString.Length > 1)
            {
                string subString = inputString.Substring(0, inputString.Length - 1);
                BigInteger sum = 0;

                for (int i = 0; i < subString.Length; i += 2)
                {
                    int digit = subString[i] - '0';
                    sum += digit;
                }
                if (sum != 0)
                {
                    product *= sum;
                }
                
                inputString = subString;
            }
            return product.ToString();
        }

        static void Main()
        {
            string number = Console.ReadLine();
            string result = String.Empty;
            int transformations = 0;

            for (int i = 0; i < 10; i++)
            {
                result = transformation(number);
                ++transformations;
                if(result.Length == 1)
                {
                    break;
                }
                else
                {
                    number = result;
                }
            }
            if (transformations != 10)
            {
                Console.WriteLine(transformations);
            }
            Console.WriteLine(result);
            
        }
    }

