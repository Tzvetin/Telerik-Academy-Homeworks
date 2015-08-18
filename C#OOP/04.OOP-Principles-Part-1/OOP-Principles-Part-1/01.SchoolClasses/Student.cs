using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Student : Person
    {
        private int classNumber;
        private static HashSet<int> classNumbers;

        static Student()
        {
            classNumbers = new HashSet<int>();
        }

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Class number must be positive number.");
                }
                if (classNumbers.Contains(value))
                {
                    throw new ArgumentException("The Class number is already used");
                }
                this.classNumber = value;
                classNumbers.Add(value);
            }
        }
    }
}
