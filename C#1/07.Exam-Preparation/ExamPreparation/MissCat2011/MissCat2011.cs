using System;

    class MissCat2011
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int vote = 0;
            int[] cats = new int[10];
            int maxVotes = 0;
            int winnerCat = 0;
            for (int i = 0; i < N; i++)
            {
                vote = int.Parse(Console.ReadLine());
                cats[vote-1]++; 
            }
            for (int j = 0; j < 10; j++)
            {
                if (cats[j] > maxVotes)
                {
                    maxVotes = cats[j];
                    winnerCat = j+1;
                }
            }
            Console.WriteLine(winnerCat);
        }
    }

