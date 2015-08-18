using System;

class IsoscelesTriangle
{
    static void Main()
    {
        //© symbol with Unicode code U+00A9
        char symbol = '\u00A9';
        Console.WriteLine("   {0}", symbol);
        Console.WriteLine("  {0} {0}", symbol);
        Console.WriteLine(" {0}   {0}", symbol);
        Console.WriteLine("{0} {0} {0} {0}", symbol);
    }
}

