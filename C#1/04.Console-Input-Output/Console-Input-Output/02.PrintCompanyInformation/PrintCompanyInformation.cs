using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Write the company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Write the company address: ");
            string address = Console.ReadLine();
            Console.Write("Write the company phone number: ");
            string phone = Console.ReadLine();
            Console.Write("Write the company fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Write the company website: ");
            string website = Console.ReadLine();
            Console.Write("Write the manager's first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Write the manager's last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Write the manager's age: ");
            ushort age = ushort.Parse(Console.ReadLine());
            Console.Write("Write the manager's phone number: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Company Details: ");
            Console.WriteLine(companyName);
            Console.WriteLine("Address:  {0}", address);
            Console.WriteLine("Tel.:  {0}", phone);
            Console.WriteLine("Fax:  {0}", fax);
            Console.WriteLine("Website:  {0}", website);
            Console.WriteLine("Manager:  {0} {1} (age: {2}, tel.: {3})", managerFirstName, managerLastName, age, managerPhone);
           
        }
    }

