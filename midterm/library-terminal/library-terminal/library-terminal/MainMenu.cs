using System;
using System.Collections.Generic;
using System.Text;

namespace library_terminal
{
    public class MainMenu
    {
        public static Enum DisplayMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");

            if (Enum.TryParse<MenuEnum>(Console.ReadLine(), out var userMenuSelection))
            {
                return userMenuSelection;
            }
            return null;
        }
    }
}
