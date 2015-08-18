using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03.StudentClass
{
    class StudentClassMain
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FirstName = "Pesho";
            student1.MiddleName = "Peshev";
            student1.LastName = "Peshev";
            student1.SSN = 12345;
            student1.University = University.SofiaUniversity;

            Student student2 = new Student();
            student2.FirstName = "Pesho";
            student2.MiddleName = "Peshev";
            student2.LastName = "Peshev";
            student2.SSN = 12345;
            student2.University = University.SofiaUniversity;

            Console.WriteLine("TEST STUDENT");
            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student2.GetHashCode());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student1 == student2);
            Console.WriteLine(student1 != student2);
            Console.WriteLine();
            Console.WriteLine("TEST CLONE");
            Student student3 = new Student();
            student3 = student2.Clone();
            Console.WriteLine(student3);
            Console.WriteLine();
            Console.WriteLine("TEST COMPARE");
            Console.WriteLine(student3.CompareTo(student1));
        }
    }
}
