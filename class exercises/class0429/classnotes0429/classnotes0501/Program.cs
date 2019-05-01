using System;

namespace classnotes0501
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal("Arnold");
            var animal2 = new Animal("Larry", 35);

            animal.Age = 23;

            Console.ReadLine();
        }
    }


}
