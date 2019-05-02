using System;

namespace classnotes0501
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new AnimalBase();
            var animal2 = new AnimalBase();

            animal.Age = 23;

            var dog = new DogBase();

            dog.Age = 2;
            dog.Name = "Axl";
            Console.WriteLine(dog.Bark());

            var poodle = new Poodle();

            poodle.Age = 3;
            poodle.Name = "foo";
            poodle.IsFurTangled = true;
            Console.WriteLine(poodle.Bark());



            Console.ReadLine();
        }
    }


}
