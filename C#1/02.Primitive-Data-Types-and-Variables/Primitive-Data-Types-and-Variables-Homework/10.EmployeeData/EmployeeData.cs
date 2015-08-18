using System;

class EmployeeData
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        uint IDNumber;
        uint uniqueEmployeeNumber;

        firstName = "Mladen";
        familyName = "Savov";
        age = 36;
        gender = 'm';
        IDNumber = 345678;
        uniqueEmployeeNumber = 27560010;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n",
            firstName, familyName, age, gender, IDNumber, uniqueEmployeeNumber);
    }
}

