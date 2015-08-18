//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
//by first name and last name in descending order.
//Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.OrderStudents
{
    class OrderStudents
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
            Console.WriteLine("lambda expressions:");
            var sortedStudents = studentsArray.OrderBy(student => student.FirstName)
                                              .ThenBy(student => student.LastName);
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("LINQ:");
            var students =
                from st in studentsArray
                orderby st.FirstName, st.LastName
                select st;
            foreach (var stud in students)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName);
            }
        }
    }
}
