using System;

namespace Assessment3a
{
    class Program
    {
        static void Main(string[] args)
        {

            SpaceShuttle shuttle = new SpaceShuttle();

            Console.WriteLine(shuttle.Launch());

            Console.ReadLine();
        }
    }
}
