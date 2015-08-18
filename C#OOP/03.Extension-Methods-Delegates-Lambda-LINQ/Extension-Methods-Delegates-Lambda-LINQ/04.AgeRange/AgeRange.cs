using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AgeRange
{
    class AgeRange
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
                where (student.Age >= 18 && student.Age <= 24)
                select student;
            foreach (var s in students)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }
        }
    }
}
