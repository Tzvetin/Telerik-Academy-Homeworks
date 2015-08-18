using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            BigInteger result = 0;

            int position = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == '@')
                {
                    break;
                }
                else if (symbol >= '0' && symbol <= '9')
                {
                    int digit = symbol - '0';
                    result *= digit;
                }
                else if (symbol >= 'a' & symbol <= 'z')
                {
                    int letterNumber = symbol - 'a';
                    result += letterNumber;
                }
                else if (symbol >= 'A' & symbol <= 'Z')
                {
                    int letterNumber = symbol - 'A';
                    result += letterNumber;
                }
                else
                {
                    result %= module;
                }

                ++position;
            }

            Console.WriteLine(result);
        }
    }

