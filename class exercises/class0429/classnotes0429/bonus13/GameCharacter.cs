using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13
{
    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public void Play()
        {
            Console.WriteLine($"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}.)");

        }

    }
}
