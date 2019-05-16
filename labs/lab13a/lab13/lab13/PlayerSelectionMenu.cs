using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    public class PlayerSelectionMenu
    {
        public static Enum DisplayMenu()
        {
            Console.WriteLine("Select a player");
            Console.WriteLine("1 - Rocky Rock");
            Console.WriteLine("2 - Random Raven");
            Console.WriteLine("3 - Choose your");

            if (Enum.TryParse<RoshamboEnum>(Console.ReadLine(), out var userMenuSelection))
            {
                return userMenuSelection;
            }
            return null;
        }
    }
}
