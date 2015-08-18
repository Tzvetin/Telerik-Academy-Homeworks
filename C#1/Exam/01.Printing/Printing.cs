using System;

    class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double priceOfRealm = double.Parse(Console.ReadLine());

            int sheetsPerRealm = 500;

            int totalSheets = numberOfStudents * sheets;

            double realms = (double)totalSheets / sheetsPerRealm;

            double moneySaved = realms * priceOfRealm;
                        
            Console.WriteLine("{0:0.00}", moneySaved);
        }
    }

