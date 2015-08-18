using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(int age, string name, bool isFemale) : base(age, name, isFemale)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau");
        }

        public string Bark()
        {
            return string.Format("{0} is barking", this.Name);
        }
    }
}
