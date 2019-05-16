using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class PlayerSelectionMenu
    {
        public static PlayerUser DisplayMenu()
        {
            PlayerUser user = new PlayerUser();

            Console.Write("Name: ");
            user.Name = Console.ReadLine();

            Console.Write("Throw: ");
            user.Roshambo = Enum.Parse<RoshamboEnum>(Console.ReadLine());

            return user;
        }
    }
}
