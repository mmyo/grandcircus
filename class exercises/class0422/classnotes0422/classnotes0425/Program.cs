using System;

namespace classnotes0425
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int result = MathHelper.Sum(5, 6);

            var meeko = new Animal();

            meeko.SetName("Meeko");

            var lizzy = new Animal();
            lizzy.SetName("Lizzy");

            Console.WriteLine(meeko.GetName());
            Console.WriteLine(lizzy.GetName());

            Console.ReadLine();
        }
    }
}
