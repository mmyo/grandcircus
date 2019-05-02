using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13
{
    public class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }

    }
}
