// Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;

class BinaryToHexadecimal
{
    static char GetChar(string s)
    {
        switch (s)
        {
            case "0000": return '0';
            case "0001": return '1';
            case "0010": return '2';
            case "0011": return '3';
            case "0100": return '4';
            case "0101": return '5';
            case "0110": return '6';
            case "0111": return '7';
            case "1000": return '8';
            case "1001": return '9';
            case "1010": return 'A';
            case "1011": return 'B';
            case "1100": return 'C';
            case "1101": return 'D';
            case "1110": return 'E';
            case "1111": return 'F';
            default: return 'X';
        }

    }

    static string ConvertToHexadecimal(string binary)
    {
        string hexaNum = "";

        for (int i = 0; i < binary.Length; i += 4)
        {
            string nibble = "";
            for (int j = 0; j < 4; j++)
            {
                nibble += binary[i + j];
            }
            hexaNum += GetChar(nibble);
        }
        return hexaNum;
    }
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        if (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = new String('0', 4 - binaryNumber.Length % 4) + binaryNumber;
        }
        Console.WriteLine(ConvertToHexadecimal(binaryNumber));
    }
}

