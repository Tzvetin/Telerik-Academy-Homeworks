using System;

class StringsAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object greeting = first + ' ' + second;
        Console.WriteLine(greeting);
        string third = (string)greeting;
        Console.WriteLine(third);
    }
}

