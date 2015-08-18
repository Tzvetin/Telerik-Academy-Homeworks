/*
Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class AnimalHierarchyMain
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[]
            {
                new Dog(7, "Sharo", false),
                new Dog(9, "Rita", true),
                new Dog(4, "Strela", true)
            };
            Frog[] frogs = new Frog[]
            {
                new Frog(2, "Pesho", false),
                new Frog(1, "Gosho", false)
            };
            Cat[] cats = new Cat[]
            {
                new Cat(4, "Boyko", false),
                new Cat(8, "Klara", true)
            };
            Kitten[] kittens = new Kitten[]
            {
                new Kitten(2, "Lora"),
                new Kitten(1, "Sara")
            };
            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat(1, "Tom"),
                new Tomcat(2, "Johnny")
            };

            Console.WriteLine("Dogs average age: {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Frogs average age: {0:F2}", Animal.AverageAge(frogs));
            Console.WriteLine("Cats average age: {0:F2}", Animal.AverageAge(cats));
            Console.WriteLine("Kittens average age: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Tomcats average age: {0:F2}", Animal.AverageAge(tomcats));

            Console.WriteLine(dogs[0].Bark());
            dogs[1].MakeSound();
            Console.WriteLine(frogs[1].Jump());
            frogs[0].MakeSound();
            Console.WriteLine(cats[0].Sleep());
            cats[1].MakeSound();
            Console.WriteLine(kittens[0].Play());
            kittens[1].MakeSound();
            Console.WriteLine(tomcats[0].Sleep());
            tomcats[1].MakeSound();
        }
    }
}
