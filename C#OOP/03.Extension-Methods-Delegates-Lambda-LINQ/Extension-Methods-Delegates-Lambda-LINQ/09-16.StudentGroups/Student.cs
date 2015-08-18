using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.StudentGroups
{
    //Problem 9. Student groups
    // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    class Student
    {
        //Fields
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private Group groupNumber;

        //Constructor
        public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.marks = marks;
            this.GroupNumber = groupNumber;
        }

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("First name cannot be null!");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
            if (value == null)
                {
                    throw new ArgumentException("Last name cannot be null!");
                }
            }
        }
        public string FN
        {
            get { return this.fn; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Faculty number cannot be null!");
                }
                this.fn = value;
            }
        }
        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Telephone number cannot be null!");
                }
                this.tel = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Email address cannot be null!");
                }
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
        }
        //Introduce a property GroupNumber in the Student class.
        public Group GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                this.groupNumber = value;
            }
        }
    }
}
