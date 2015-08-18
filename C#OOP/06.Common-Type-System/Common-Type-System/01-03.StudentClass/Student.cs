/*
  Problem 1. Student class
Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
    mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03.StudentClass
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (student.FirstName == this.FirstName &&
                student.MiddleName == this.MiddleName &&
                student.LastName == this.LastName &&
                student.SSN == this.SSN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.FirstName + " " + this.MiddleName + " ");
            sb.AppendLine(this.LastName);
            sb.Append(this.SSN.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1.Equals(student2));
        }

        /*
        Problem 2. IClonable
        Add implementations of the ICloneable interface. 
        The Clone() method should deeply copy all object's fields into a new object of type Student.
        */
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student student = new Student();

            student.FirstName = this.FirstName;
            student.MiddleName = this.MiddleName;
            student.LastName = this.LastName;
            student.SSN = this.SSN;
            student.PermanentAddress = this.PermanentAddress;
            student.MobilePhone = this.MobilePhone;
            student.Email = this.Email;
            student.Course = this.Course;
            student.Specialty = this.Specialty;
            student.University = this.University;
            student.Faculty = this.Faculty;

            return student;
        }

        /*
        Problem 3. IComparable
        Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
        and by social security number (as second criteria, in increasing order). 
        */
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            if (this.MiddleName != student.MiddleName)
            {
                return this.MiddleName.CompareTo(student.MiddleName);
            }
            if (this.LastName != student.LastName)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return this.SSN.CompareTo(student.SSN);
            }
            return 0;
        }
    }
}
