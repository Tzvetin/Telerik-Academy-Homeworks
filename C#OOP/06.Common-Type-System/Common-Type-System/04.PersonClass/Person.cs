/*
Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 Override ToString() to display the information of a person and if age is not specified – to say so.
Write a program to test this functionality.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age)
            : this(name)
        {
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value >= 120)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or bigger than 120!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            if (this.Age == null)
            {
                sb.AppendLine("Age: unspecified");
            }
            else
            {
                sb.AppendLine("Age: " + this.Age);
            }
            return sb.ToString();
        }
    }
}
