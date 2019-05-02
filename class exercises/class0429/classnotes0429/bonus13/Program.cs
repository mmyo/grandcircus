using System;

namespace bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameChar = new GameCharacter();
            gameChar.Name = "Spongebob - Game Char";
            gameChar.Strength = 10;
            gameChar.Intelligence = 100;

            var warrior1 = new Warrior();
            warrior1.Name = "Patrick - Warrior";
            warrior1.Strength = 100;
            warrior1.Intelligence = 10;
            warrior1.WeaponType = "A fish";
            //warrior1.Play();

            var warrior2 = new Warrior();
            warrior2.Name = "Louise - Warrior";
            warrior2.Strength = 100;
            warrior2.Intelligence = 10;
            warrior2.WeaponType = "A fish";

            var magicChar = new MagicUsingCharacter();
            magicChar.Name = "Squidward - Magic Char";
            magicChar.Strength = 100;
            magicChar.Intelligence = 10;
            magicChar.MagicalEnergy = 99;

            var wizard1 = new Wizard();
            wizard1.Name = "Mr Krabs - Wizard";
            wizard1.Strength = 10;
            wizard1.Intelligence = 100;
            wizard1.MagicalEnergy = 99;
            wizard1.SpellNumber = 42;

            var wizard3 = new Wizard();
            wizard3.Name = "Plankton - Wizard";
            wizard3.Strength = 5;
            wizard3.Intelligence = 80;
            wizard3.MagicalEnergy = 99;
            wizard3.SpellNumber = 42;

            var wizard4 = new Wizard();
            wizard4.Name = "Sandy - Wizard";
            wizard4.Strength = 10;
            wizard4.Intelligence = 90;
            wizard4.MagicalEnergy = 99;
            wizard4.SpellNumber = 42;

            GameCharacter[] gameCharArray = new GameCharacter[5] { warrior1, warrior2, wizard1, wizard3, wizard4 };
            //two warriors and three wizards

            foreach (var item in gameCharArray)
            {
                item.Play();
                //warrior1.Play();              
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
