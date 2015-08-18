using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class MathProblem
    {
        static List<char> transition = new List<char>();

        static void Main()
        {
            string input = Console.ReadLine().Trim();
            string[] lettersNumbers = input.Split(' ');
            int sum = 0;

            for (int j = 0; j < 19; j++)
            {
                transition.Add((char)((int)'a' + j));
            }

            for (int i = 0; i < lettersNumbers.Length; i++)
            {
                sum += StringToNumber(lettersNumbers[i]);
            }

            Console.WriteLine("{0} = {1}", NumberToString(sum), sum);
        }

        static int StringToNumber(string lettersNumber)
        {
            int result = 0;
            
            for (int i = 0; i < lettersNumber.Length; i++)
            {
                int numberIn19Base = transition.IndexOf(lettersNumber[i]);
                result += numberIn19Base * PowerOf19(lettersNumber.Length - i - 1);
            }
            return result;
        }

        static int PowerOf19(int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= 19;
            }
            return result;
        }

        static string NumberToString(int sum)
        {
            StringBuilder result = new StringBuilder();

            do
            {
                int digitIn19th = (int)(sum % 19);
                result.Insert(0, transition[digitIn19th]);
                sum /= 19;
            }
            while (sum > 0);

            return result.ToString();

        }

    }

