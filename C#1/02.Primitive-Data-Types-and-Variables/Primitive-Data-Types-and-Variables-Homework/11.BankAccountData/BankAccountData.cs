using System;

class BankAccountData
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance;
        string bankName;
        string IBAN;
        ulong creditCardNumber1;
        ulong creditCardNumber2;
        ulong creditCardNumber3;
        firstName = "Mladen";
        middleName = "Mladenov";
        lastName = "Savov";
        balance = 767.54M;
        bankName = "Bulbank";
        IBAN = "UNCRBGSF760349239595";
        creditCardNumber1 = 245623562351512451;
        creditCardNumber2 = 358479856994784575;
        creditCardNumber3 = 357346736834836773;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n",
            firstName, middleName, lastName, balance, bankName, IBAN,
            creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}

