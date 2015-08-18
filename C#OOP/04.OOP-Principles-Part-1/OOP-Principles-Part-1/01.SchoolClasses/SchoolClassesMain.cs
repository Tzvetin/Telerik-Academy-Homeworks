/*
We are given a school. In the school there are classes of students. Each class has a set of teachers. 
Each teacher teaches a set of disciplines. Students have name and unique class number. 
Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).

Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
define the class hierarchy and create a class diagram with Visual Studio.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    class SchoolClassesMain
    {
        static void Main(string[] args)
        {
            Student peshoStudent = new Student("Petar Petrov", 17);
            Student goshoStudent = new Student("Georgi Georgiev", 5);
            Student mimiStudent = new Student("Maria Petrova", 12);
            Student geriStudent = new Student("Gergana Georgieva", 7);
            Student ivanStudent = new Student("Ivan Ivanov", 10);
            ivanStudent.AddComment("Nevertheless...");
            Discipline maths = new Discipline("Mathematics", 3, 3);
            Discipline phy = new Discipline("Physics", 2, 2);
            Discipline info = new Discipline("Informatics", 2, 2);
            Discipline chem = new Discipline("Chemistry", 1, 1);
            Discipline eng = new Discipline("English", 2, 2);
            Teacher haralampiTeacher = new Teacher("Haralampi Haralampiev", new List<Discipline> { maths, info });
            Teacher gospodinTeacher = new Teacher("Gospodin Gospodinov", new List<Discipline> { eng, maths });
            Teacher dimoTeacher = new Teacher("Dimo Dimov", new List<Discipline> { phy, chem });
            Class elevenA = new Class("11A", new List<Teacher>{gospodinTeacher, dimoTeacher});
            Class elevenB = new Class("11B", new List<Teacher>{haralampiTeacher, dimoTeacher});
            School ourSchool = new School(new List<Class>{ elevenA, elevenB });
            Console.WriteLine(ivanStudent);
            ivanStudent.PrintComment();
            Console.WriteLine(dimoTeacher);
            Console.WriteLine(elevenA);
            Console.WriteLine(ourSchool);
        }
    }
}
