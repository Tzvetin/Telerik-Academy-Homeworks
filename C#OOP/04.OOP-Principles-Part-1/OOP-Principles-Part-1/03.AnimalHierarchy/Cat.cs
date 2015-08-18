using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(int age, string name, bool isFemale) : base(age, name, isFemale)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miao");
        }

        public string Sleep()
        {
            return string.Format("{0} is sleeping", this.Name);
        }
    }
}
