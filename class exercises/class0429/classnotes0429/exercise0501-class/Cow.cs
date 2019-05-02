using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0501_class
{
    class Cow
    {
        public int Weight { get; set; }

        public bool IsAlive { get; set; }

        public Cow()
        {
            Weight = 50;
            IsAlive = true;
        }

        public void Feed(string food)
        {

            switch (food.ToLower())
            {
                case "carrot":
                    Weight = Weight + 1;
                    break;
                case "grass":
                    Weight = Weight + 1;
                    break;
                case "pie":
                    Weight = Weight + 10;
                    break;
                default:
                    Console.WriteLine("\nUm, cows don't eat that.");
                    break;
            }

        }
    }
}
