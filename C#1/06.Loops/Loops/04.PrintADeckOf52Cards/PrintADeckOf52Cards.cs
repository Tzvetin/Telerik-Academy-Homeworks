using System;

    class PrintADeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case (2): 
                        case (3): 
                        case (4): 
                        case (5): 
                        case (6): 
                        case (7): 
                        case (8): 
                        case (9):
                        case (10): Console.Write(i); break;
                        case (11): Console.Write("J"); break;
                        case (12): Console.Write("Q"); break;
                        case (13): Console.Write("K"); break;
                        case (14): Console.Write("A"); break;
                    }
                    switch (j)
                    {
                        case (0): Console.Write(" of spades, "); break;
                        case (1): Console.Write(" of clubs, "); break;
                        case (2): Console.Write(" of hearts, "); break;
                        case (3): Console.WriteLine(" of diamonds"); break;
                    }

                }

            }
        }
    }

