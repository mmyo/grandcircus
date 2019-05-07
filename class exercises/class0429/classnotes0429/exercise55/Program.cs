using System;
using System.Collections.Generic;

namespace exercise55
{
    class Program
    {
        static void Main(string[] args)
        {

            var rickRattleSnake = new Snake();
            rickRattleSnake.IsAlive = true;
            rickRattleSnake.HasScales = true;
            rickRattleSnake.IsVenomous = true;

            var lizzyLizard = new Lizard();
            lizzyLizard.IsAlive = true;
            lizzyLizard.HasScales = true;
            lizzyLizard.TailLength = 5;

            var harryHummingBird = new HummingBird();
            harryHummingBird.CanFly = true;
            harryHummingBird.FavoriteNectar = "sunflower";

            var animalList = new List<AnimalBase>();

            animalList.Add(rickRattleSnake);
            animalList.Add(lizzyLizard);
            animalList.Add(harryHummingBird);

            Console.ReadLine();
        }
    }
}
