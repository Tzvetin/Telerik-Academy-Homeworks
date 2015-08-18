using System;

    class BitsToBits
    {
        static int MaximalSequence(string input, char value)
        {
            char maxCountValue = value;
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == maxCountValue)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        count = 0;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            //last element
            if (count > maxCount)
            {
                maxCount = count;
            }

            return maxCount;

        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string buffer = String.Empty;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(number, 2).PadLeft(30, '0');

                if (binary.Length > 30)
                {
                    string subString = binary.Substring(binary.Length - 30);
                    binary = subString;
                }

                buffer += binary;

            }
            Console.WriteLine(MaximalSequence(buffer, '0'));
            Console.WriteLine(MaximalSequence(buffer, '1'));

        }
    }

