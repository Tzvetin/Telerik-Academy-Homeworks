using System;

class BinaryToDecimalNumber
{
    static long ConvertToDecimal(string binary)
    {
        long decimalNum = 0;
        int power = 1;
        for (int i = binary.Length - 1; i >= 0; i--, power *= 2)
        {
            int binaryValue = int.Parse(binary[i].ToString());
            decimalNum += binaryValue * power;
        }
        return decimalNum;
    }

    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine(ConvertToDecimal(binaryNumber));
    }
}

