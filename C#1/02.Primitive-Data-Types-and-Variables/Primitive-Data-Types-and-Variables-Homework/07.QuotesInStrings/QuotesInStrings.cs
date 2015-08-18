using System;

class QuotesInStrings
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(first);
        string second = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(second);
    }
}

