using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers separated by space: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                double temp = double.Parse(numbers[i]);
                sum += temp;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }

