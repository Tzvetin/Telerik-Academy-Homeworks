using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private bool isFemale;

        public Animal(int age, string name, bool isFemale)
        {
            this.Age = age;
            this.Name = name;
            this.IsFemale = isFemale;
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or more than 100");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }
        private bool IsFemale
        {
            get { return this.isFemale; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentOutOfRangeException("Invalid sex");
                }
                this.isFemale = value;
            }
        }

        public static double AverageAge(Animal[] arr)
        {
            return arr.Average(x => x.Age);
        }

        public abstract void MakeSound();
    }
}
