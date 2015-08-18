using System;

    class OddNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long[] input = new long[N];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = long.Parse(Console.ReadLine());
            }
           
            Array.Sort(input);
            int count = 1;
            int index = 0;
            long result = 0;
            
                while (index < input.Length - 1)
                {
                    if (input[index] == input[index + 1])
                    {
                        count++; 
                    }
                    else
                    {
                        if (count % 2 != 0)
                        {
                            result = input[index];
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                    index++;
                }
                if (result == 0)
                {
                    Console.WriteLine(input[input.Length - 1]);
                }
                else
                {
                    Console.WriteLine(result);
                }

           
        }
    }

