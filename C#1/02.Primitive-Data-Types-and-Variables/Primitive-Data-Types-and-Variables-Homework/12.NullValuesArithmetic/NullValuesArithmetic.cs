using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 5;
        b = 5.2;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = 5 + null;
        b = 5.2 + null;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

