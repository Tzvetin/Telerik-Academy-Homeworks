using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

    class SumOfDifferences
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersAsStrings = input.Split(' ');
            long[] sequence = new long[numbersAsStrings.Length];

            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                sequence[i] = long.Parse(numbersAsStrings[i]);
            }

            int index = 1;
            BigInteger oddAbsoluteDifferencesSum = 0;

            while(true)
            {
                BigInteger absDifference = 0;
                if(sequence[index] > sequence[index - 1])
                {
                    absDifference = (BigInteger)(sequence[index] - sequence[index - 1]);
                }
                else
                {
                    absDifference = (BigInteger)(sequence[index - 1] - sequence[index]);
                }

                int jump; 
                if (absDifference % 2 != 0)
                {
                    jump = 1;
                    oddAbsoluteDifferencesSum += absDifference;
                }
                else
                {
                    jump = 2;
                }
                if (index + jump >= sequence.Length)
                {
                    break;
                }
                index += jump;
            }
            Console.WriteLine(oddAbsoluteDifferencesSum);
        }
    }

