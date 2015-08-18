/*
Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. 
Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns 
  money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class StudentsAndWorkersMain
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Rumen", "Zlatev", 67),
                new Student("Lubomir", "Ivanov", 59),
                new Student("Iordan", "Geshakov", 79),
                new Student("Angel", "Iliev", 63),
                new Student("Nikolay", "Stamenov", 70),
                new Student("Vanya", "Ignatova", 93),
                new Student("Natalia", "Popova", 88),
                new Student("Nadezhda", "Hristova", 60),
                new Student("Teodora", "Dimitrova", 65),
                new Student("Bela", "Benova", 90),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Phil", "Anselmo", 1000, 8),
                new Worker("Phil", "Collins", 800, 8),
                new Worker("Jonathan", "Davis", 850, 8),
                new Worker("David", "Lynch", 1200, 4),
                new Worker("Dave", "Mustaine", 600, 6),
                new Worker("Joe", "Cocker", 100, 4),
                new Worker("Nathalie", "Imbruglia", 1100, 6),
                new Worker("Catherine", "Deneuve", 900, 8),
                new Worker("Mila", "Jovovich", 1400, 8),
                new Worker("Samantha", "Fox", 400, 6),
            };

            Console.WriteLine("Students in ascending order by grades: ");
            var studentsByGrade = students.OrderBy(g => g.Grade);
            foreach (var st in studentsByGrade)
            {
                Console.WriteLine(st + " " + st.Grade);
            }
            Console.WriteLine();

            Console.WriteLine("Workers in descending order by money per hour: ");
            var workersByMoney = workers.OrderByDescending(x => x.MoneyPerHour());
            foreach (var w in workersByMoney)
            {
                Console.WriteLine(string.Format("{0} {1:C}", w, w.MoneyPerHour()));
            }
            Console.WriteLine();

            Console.WriteLine("Merged lists sorted by first name and last name: ");
            var merged = studentsByGrade.Concat<Human>(workersByMoney).OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var m in merged)
            {
                Console.WriteLine(m);
            }
        }
    }
}
