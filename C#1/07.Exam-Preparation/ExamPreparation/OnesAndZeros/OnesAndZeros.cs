using System;

    class OnesAndZeros
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');

             if(binary.Length > 16)
             {
                 string subString = binary.Substring(binary.Length - 16);
                 binary = subString; 
             }
             
            char[,] output = new char[5, 63];
            for (int i = 0, position = 0; i < 16; i++, position += 4)
            {
                if(binary[i] == '1')
                {
                    output[0, position] = '.';
                    output[1, position] = '#';
                    output[2, position] = '.';
                    output[3, position] = '.';
                    output[4, position] = '#';

                    output[0, position + 1] = '#';
                    output[1, position + 1] = '#';
                    output[2, position + 1] = '#';
                    output[3, position + 1] = '#';
                    output[4, position + 1] = '#';

                    output[0, position + 2] = '.';
                    output[1, position + 2] = '.';
                    output[2, position + 2] = '.';
                    output[3, position + 2] = '.';
                    output[4, position + 2] = '#';

                    if(i != 15)
                    { 
                        output[0, position + 3] = '.';
                        output[1, position + 3] = '.';
                        output[2, position + 3] = '.';
                        output[3, position + 3] = '.';
                        output[4, position + 3] = '.';
                    }
                }
                else
                {
                    output[0, position] = '#';
                    output[1, position] = '#';
                    output[2, position] = '#';
                    output[3, position] = '#';
                    output[4, position] = '#';

                    output[0, position + 1] = '#';
                    output[1, position + 1] = '.';
                    output[2, position + 1] = '.';
                    output[3, position + 1] = '.';
                    output[4, position + 1] = '#';

                    output[0, position + 2] = '#';
                    output[1, position + 2] = '#';
                    output[2, position + 2] = '#';
                    output[3, position + 2] = '#';
                    output[4, position + 2] = '#';

                    if (i != 15)
                    {
                        output[0, position + 3] = '.';
                        output[1, position + 3] = '.';
                        output[2, position + 3] = '.';
                        output[3, position + 3] = '.';
                        output[4, position + 3] = '.';
                    }
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 63; col++)
                {
                    Console.Write(output[row, col]);
                }
                Console.WriteLine();
            }
        }
    }

