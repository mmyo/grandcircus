using System;
using System.Collections.Generic;
using System.Text;

namespace bonus13
{
    public class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"WeaponType: {WeaponType}");
        }
    }
}
