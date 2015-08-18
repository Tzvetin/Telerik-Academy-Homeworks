using System;

    class TheHorror
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int numberOfDigits = 0;
            int sumOfDigits = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    string digit = input[i].ToString();
                    numberOfDigits++;
                    sumOfDigits += int.Parse(digit);
                }
            }
            Console.WriteLine("{0} {1}", numberOfDigits, sumOfDigits);
        }
    }

