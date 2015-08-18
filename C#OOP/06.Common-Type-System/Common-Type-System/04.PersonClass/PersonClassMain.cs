using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonClass
{
    class PersonClassMain
    {
        static void Main(string[] args)
        {
            Person peshoPerson = new Person("Pesho", 21);
            Console.WriteLine(peshoPerson);
            Person goshoPerson = new Person("Gosho", null);
            Console.WriteLine(goshoPerson);
            Person mimiPerson = new Person("Mimi");
            Console.WriteLine(mimiPerson);
        }
    }
}
