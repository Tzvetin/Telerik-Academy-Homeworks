using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currentNumber = int.Parse(inputNumbers[i]);
                if (i % 2 != 0)
                {
                    evenProduct *= currentNumber;
                }
                else
                {
                    oddProduct *= currentNumber;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Yes!");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("odd_product: {0}", oddProduct);
                Console.WriteLine("even_product: {0}", evenProduct);
            }
            
        }
    }

