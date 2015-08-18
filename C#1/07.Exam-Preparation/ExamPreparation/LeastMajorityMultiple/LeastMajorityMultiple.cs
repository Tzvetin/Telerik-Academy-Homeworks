using System;

    class LeastMajorityMultiple
    {
        static void Main()
        {
            int[] input = new int[5];
            for (int i = 0; i < 5; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(input);
            int start = input[2];
           
            while (true)
                {
                    int count = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            if (start % input[i] == 0)
                            {
                                count++; 
                            }
                        }
                   if (count >= 3)
                   {
                       break;
                   }
                   start++;
                }
            Console.WriteLine(start);
        }
    }

