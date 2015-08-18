using System;

    class SevenlandNumbers
    {
        static void Main()
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            int hundredsDigit = (number / 100) % 10;
            int tensDigit = (number / 10) % 10;
            int unitsDigit = number % 10;

            //Solution
            int hundredsDigitNext = hundredsDigit;
            int tensDigitNext = tensDigit;
            int unitsDigitNext = unitsDigit;
            if (number == 666)
            {
                Console.WriteLine(1000);
            }
            else
            {
                if (unitsDigit == 6 && tensDigit == 6)
                {
                    hundredsDigitNext++;
                    tensDigitNext = 0;
                    unitsDigitNext = 0;
                }
                else if (unitsDigit == 6)
                {
                    tensDigitNext++;
                    unitsDigitNext = 0;
                }
                else
                {
                    unitsDigitNext++;
                }

                //Output
                Console.WriteLine(hundredsDigitNext * 100 + tensDigitNext * 10 + unitsDigitNext);
            }
            
        }
    }

