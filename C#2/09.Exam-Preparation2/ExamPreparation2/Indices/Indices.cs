using System;
using System.Text;

    class Indices
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int[] arrayOfNumbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                arrayOfNumbers[i] = int.Parse(array[i]);
            }
            bool[] visited = new bool[N];
            int currentIndex = 0;
            int loopStart = -1;
            StringBuilder result = new StringBuilder();
            while (true)
            {
                if (currentIndex < 0 || currentIndex >= N)
                {
                    break;
                }
                if (visited[currentIndex])
                {
                    loopStart = currentIndex;
                    break;
                }
                result.Append(currentIndex);
                result.Append(' ');
                visited[currentIndex] = true;
                currentIndex = arrayOfNumbers[currentIndex];
            }
            
            if (loopStart >= 0)
            {
                int index = result.ToString().IndexOf((" " + loopStart + " ").ToString());
                if (index < 0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    result[index] = '(';
                }
                
                result[result.Length - 1] = ')';
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }

