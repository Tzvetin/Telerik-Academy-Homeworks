//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
using System;

class Program
{
    // GetChar(15) -> 'F'
    static char GetChar(int i)
    {
        if (i >= 10) return (char)('A' + i - 10);
        else return (char)('0' + i);
    }
    // GetNumber("587", 2) -> 7
    static int GetNumber(string s, int i)
    {
        if (s[i] >= 'A') return s[i] - 'A' + 10;
        else return s[i] - '0';
    }

    static string Base10ToBaseY(int d, int y)
    {
        string h = String.Empty;
        while (d != 0)
        {
            h = GetChar(d % y) + h;
            d /= y;
        }
        return h;
    }

    static int BaseXToBase10(string h, int x)
    {
        int d = 0;
        for (int i = h.Length - 1, p = 1; i >= 0; i--, p *= x)
        {
            d += GetNumber(h, i) * p;
        }
        return d;
    }

    static string BaseXToBaseY(string n, int x, int y)
    {
        return Base10ToBaseY(BaseXToBase10(n, x), y); // Use base 10 as proxy
    }

    static void Main()
    {
        Console.WriteLine(BaseXToBaseY("2273417", 8, 3));
    }
}