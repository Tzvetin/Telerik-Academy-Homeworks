using System;

    class ANacci
    {
        static void Main()
        {
            //Input
            string firstMember = Console.ReadLine();
            int first = firstMember[0] - 64;
            string secondMember = Console.ReadLine();
            int second = secondMember[0] - 64;
            int L = int.Parse(Console.ReadLine());
            int next;

            //Output
            Console.WriteLine((char)(first+64));
            if (L > 1)
            {
                if (first + second > 26)
                {
                    next = (first + second) % 26;
                }
                else
                {
                    next = first + second;
                }

                Console.WriteLine("{0}{1}", (char)(second + 64), (char)(next + 64));
                first = second;
                second = next;
                if (L > 2)
                {
                    for (int i = 3; i <= L; i++)
                    {
                        if (first + second > 26)
                        {
                            next = (first + second) % 26;
                        }
                        else
                        {
                            next = first + second;
                        }
                        Console.Write((char)(next + 64));
                        first = second;
                        second = next;
                        Console.Write(new String(' ', i - 2));
                        if (first + second > 26)
                        {
                            next = (first + second) % 26;
                        }
                        else
                        {
                            next = first + second;
                        }
                        Console.WriteLine((char)(next + 64));
                        first = second;
                        second = next;
                    }
                }
               
            }
            

        }
    }
