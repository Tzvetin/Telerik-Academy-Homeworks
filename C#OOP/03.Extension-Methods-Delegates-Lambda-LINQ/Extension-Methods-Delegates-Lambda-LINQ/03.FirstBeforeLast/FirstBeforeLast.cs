// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class FirstBeforeLast
    {
        static void Main(string[] args)
        {
            var studentsArray = new[]
            {
                new {FirstName = "Natalia", LastName = "Popova", Age = 25},
                new {FirstName = "Rumen", LastName = "Zlatev", Age = 26},
                new {FirstName = "Lubomir", LastName = "Ivanov", Age = 27},
                new {FirstName = "Vanya", LastName = "Ignatova", Age = 23},
                new {FirstName = "Lora", LastName = "Kamenova", Age = 22},
            };
            var students =
                from student in studentsArray
                where (student.FirstName.CompareTo(student.LastName) < 0)
                select student;
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }
        }
    }
}
