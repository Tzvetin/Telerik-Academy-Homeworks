using System;
using System.Numerics;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("How many Fibonacci Numbers do you need? ");
            uint numbersNeeded = uint.Parse(Console.ReadLine());
            BigInteger Fminus2 = 0;
            BigInteger Fminus1 = 1;
            BigInteger F = 0;
            if (numbersNeeded == 0)
            {
                Console.WriteLine("Why zero?");
            }
            else if (numbersNeeded == 1)
            {
                Console.WriteLine(Fminus2);
            }
            else if (numbersNeeded == 2)
            {
                Console.Write("{0}, ", Fminus2);
                Console.WriteLine(Fminus1);
            }
            else
            {
                Console.Write("{0}, ", Fminus2);
                Console.Write("{0}, ", Fminus1);
                for (int i = 2; i < numbersNeeded; i++)
                {
                    F = Fminus2 + Fminus1;
                    Fminus2 = Fminus1;
                    Fminus1 = F;
                    if (i == numbersNeeded - 1)
                    {
                        Console.WriteLine(F);
                    }
                    else
                    {
                        Console.Write("{0}, ", F);
                    }
                    
                }
            }
            
        }
    }

