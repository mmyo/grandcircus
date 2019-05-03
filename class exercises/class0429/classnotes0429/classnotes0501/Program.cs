using System;
using System.Collections.Generic;

namespace classnotes0501
{
    class Program
    {
        static void Main(string[] args)
        {
            //var animal = new AnimalBase();
            //var animal2 = new AnimalBase();

            //animal.Age = 23;

            //var dog = new DogBase();

            //dog.Age = 2;
            //dog.Name = "Axl";
            //Console.WriteLine(dog.Bark());

            var poodle = new Poodle("", 10, "", true);

            poodle.Age = 3;
            poodle.Name = "foo";
            poodle.IsFurTangled = true;

            Console.WriteLine(poodle.Bark());

            var listOfSomething = new List<string>();

            var york = new Yorkie("Bob", 10, "brown");

            Console.WriteLine(york.Bark());

            var dogs = new List<DogBase>();
            dogs.Add(york);
            dogs.Add(poodle);

            Console.ReadLine();
        }

        public Poodle MapToPoodle(Yorkie yorkie)
        {
            var poodle = new Poodle(yorkie.Name, yorkie.Age, yorkie.Color, true);
            return poodle;
        }
    }


}
