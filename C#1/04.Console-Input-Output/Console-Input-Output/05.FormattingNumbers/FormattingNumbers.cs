using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter an integer between 0 and 500: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter another floating-point number: ");
            double c = double.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("{0,-0:X} |{1}| {2,0:F2}|{3,-0:F3} |", a, binary, b, c);
        }
    }

