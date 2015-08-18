using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(int age, string name, bool isFemale) : base(age, name, isFemale)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kwak");
        }

        public string Jump()
        {
            return string.Format("{0} is jumping", this.Name);
        }
    }
}
