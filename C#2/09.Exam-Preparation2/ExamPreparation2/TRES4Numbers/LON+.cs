using System;
using System.Text;

    class Program
    {
        static void Main()
        {
            var numeralSystem = 9;
            var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
            ulong numberInDecimal = ulong.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            do 
            {
                int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem);
                result.Insert(0, digits[digitIn9th]);
                numberInDecimal /= (ulong)numeralSystem;
            }
            while(numberInDecimal > 0);

            Console.WriteLine(result.ToString());
            
        }
    }

