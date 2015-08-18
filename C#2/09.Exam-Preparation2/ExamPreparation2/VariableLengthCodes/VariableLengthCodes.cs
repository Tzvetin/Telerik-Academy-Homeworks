using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class VariableLengthCodes
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var numbersAsStrings = line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder encodedString = new StringBuilder();

            foreach (var str in numbersAsStrings)
            {
                var number = int.Parse(str);
                encodedString.Append(Convert.ToString(number, 2).PadLeft(8, '0'));
            }

            int n = int.Parse(Console.ReadLine());
            char[] dictionary = new char[n + 1];

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                char symbol = line[0];
                int index = int.Parse(line.Substring(1));
                dictionary[index] = symbol;
            }

            StringBuilder decoded = new StringBuilder();
            int ones = 0;

            foreach (var ch in encodedString.ToString())
            {
                if (ch == '1')
                {
                    ones++;
                }
                else
                {
                    decoded.Append(dictionary[ones]);
                    ones = 0;
                }
            }
            //special case
            if (ones > 0)
            {
                decoded.Append(dictionary[ones]);
            }
            Console.WriteLine(decoded);
        }
    }

