﻿using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("{0}, {1}", a, b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("{0}, {1}", a, b);

    }
}

