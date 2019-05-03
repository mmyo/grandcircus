using System;
using System.Collections.Generic;

namespace exercise55
{
    class Program
    {
        static void Main(string[] args)
        {

            var rattleSnake = new Snake();
            rattleSnake.IsAlive = true;
            rattleSnake.HasScales = true;
            rattleSnake.IsVenomous = true;

            var lizzyLizard = new Lizard();
            lizzyLizard.IsAlive = true;
            lizzyLizard.HasScales = true;
            lizzyLizard.TailLength = 5;

            var animalList = new List<AnimalBase>();


            Console.ReadLine();
        }
    }
}
