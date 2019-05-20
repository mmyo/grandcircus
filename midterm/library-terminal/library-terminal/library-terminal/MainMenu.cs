using System;
using System.Collections.Generic;
using System.Text;

namespace library_terminal
{
    public class MainMenu
    {
        public static Enum DisplayMainMenu()
        {
            Console.WriteLine("1 - Display All Books");
            Console.WriteLine("");

            if (Enum.TryParse<MenuEnum>(Console.ReadLine(), out var userMenuSelection))
            {
                return userMenuSelection;
            }
            return null;
        }
    }
}
