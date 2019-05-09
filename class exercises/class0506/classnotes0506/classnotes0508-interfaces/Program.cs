using System;

namespace classnotes0508_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void HonkSomething(IHonk honk)
        {
            Console.WriteLine(honk.Honk());
        }
    }
}
