using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.StudentGroups
{
    class StudentGroupsMain
    {
        static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Create a List<Student> with sample students.
            List<Student> list = new List<Student>()
            {
                new Student("Natalia", "Popova", "140032", "0887629696", "natalia@abv.bg", new List<int> {6, 3, 4, 2, 3}, new Group(2, "Computing")),
                new Student("Rumen", "Zlatev", "140034", "0899564345", "rumen@gmail.com", new List<int> {3, 2, 2, 6, 3}, new Group(2, "Physics")),
                new Student("Lubomir", "Ivanov", "140012", "0878352319", "lubo@mail.com", new List<int> {5, 2 ,2, 4, 4}, new Group(13, "Mathematics")),
                new Student("Vanya", "Ignatova", "140023", "0898967854", "vanya@gmail.com", new List<int> {6, 6, 6, 2, 2}, new Group(14, "Physics")),
                new Student("Lora", "Kamenova", "140006", "029885333", "lora@abv.bg", new List<int> {2, 2, 2, 6, 6}, new Group(9, "Biology")),
            };
            //Problem 9. Student groups
            //Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            var students =
                from element in list
                where element.GroupNumber.GroupNumber == 2
                orderby element.FirstName
                select element;
            Console.WriteLine("Students from group 2 using LINQ:");
            Print(students);


            //Problem 10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.
            var stud = list.Where(s => s.GroupNumber.GroupNumber == 2)
                                .OrderBy(s => s.FirstName);
            Console.WriteLine("Students from group 2 using extension methods:");
            Print(stud);

            //Problem 11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.
            var studentsInAbv =
                from element in list
                where element.Email.EndsWith("abv.bg")
                select element;
            Console.WriteLine("Students with emails in abv.bg using LINQ:");
            Print(studentsInAbv);

            //Problem 12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.
            var studentsInSofia =
                from element in list
                where element.Tel.StartsWith("02")
                select element;
            Console.WriteLine("Students with phones in Sofia using LINQ:");
            Print(studentsInSofia);

            //Problem 13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – 
            //FullName and Marks.
            //Use LINQ.
            int excellentMark = 6;
            var excellentStudents =
                from element in list
                where element.Marks.Contains(excellentMark)
                select new { FullName = element.FirstName + " " + element.LastName, Marks = element.Marks };
            Console.WriteLine("Students with at least one mark Excellent:");
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FullName);
                foreach (var item in student.Marks)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Problem 14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.
            int poorMark = 2;
            int timesFound = 2;
            var poorstudents =
                from element in list
                where element.Marks.Count(x => x == poorMark) == timesFound
                select new { FullName = element.FirstName + " " + element.LastName, Marks = element.Marks };
            Console.WriteLine("Students with eactly two marks Poor:");
            foreach (var student in poorstudents)
            {
                Console.WriteLine(student.FullName);
                foreach (var item in student.Marks)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Problem 15. Extract marks
            //Extract all Marks of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var students2006 =
                from element in list
                where (element.FN[4] == '0' && element.FN[5] == '6')
                select element;
            Console.WriteLine("Marks of the students that enrolled in 2006:");
            foreach (var item in students2006)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
                foreach (var mark in item.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Problem 16.* Groups
            //Extract all students from "Mathematics" department.
            //Use the Join operator.
            var studentsMath =
                from element in list
                where element.GroupNumber.DepartmentName == "Mathematics"
                select element;
            Console.WriteLine("Students from Mathematics department:");
            Print(studentsMath);

            //Problem 18. Grouped by GroupNumber
            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            //Use LINQ.
            var studentsGrouped =
                from element in list
                group element by element.GroupNumber.GroupNumber into newGroup
                orderby newGroup.Key
                select new { groupNum = newGroup.Key, studs = newGroup.ToList() };
            Console.WriteLine("Print students grouped by GroupNumber using LINQ:");
            foreach (var item in studentsGrouped)
	        {
		        Console.WriteLine(item.groupNum + ": ");
                foreach (var std in item.studs)
	            {
		            Console.WriteLine(std.FirstName + " " + std.LastName);
	            }
	        }
            Console.WriteLine();

            //Problem 19. Grouped by GroupName extensions
            //Rewrite the previous using extension methods.
            var studentsGrouped2 = list.GroupBy(s => s.GroupNumber.GroupNumber, (key, grp) => new { nmb = key, sts = grp.ToList() })
                                                                                                .OrderBy(g => g.nmb);
            Console.WriteLine("Print students grouped by GroupNumber using extension methods:");
            foreach (var item in studentsGrouped2)
            {
                Console.WriteLine(item.nmb + ": ");
                foreach (var st in item.sts)
                {
                    Console.WriteLine(st.FirstName + " " + st.LastName);
                }
            }
        }
        
    }
}
