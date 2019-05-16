using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class OpponentSelectionMenu
    {
        public static Enum DisplayMenu()
        {
            Console.WriteLine("Select an opponent");
            Console.WriteLine("1 - Rocky Rock");
            Console.WriteLine("2 - Random Raven");
            Console.WriteLine("3 - Paper Pete");

            if (Enum.TryParse<OpponentSelectionEnum>(Console.ReadLine(), out var userMenuSelection))
            {
                return userMenuSelection;
            }
            return null;
        }

        public static PlayerBase CreateOpponent(Enum selectedOpponent) 
        {
            switch (selectedOpponent)
            {
                case OpponentSelectionEnum.Player1Rock:
                    Player1Rock opponent = new Player1Rock();
                    opponent.GenerateRoshambo();
                    opponent.Name = "Rocky Rock";
                    return opponent;
                    //break;
                case OpponentSelectionEnum.Player2Random:
                    Player2Random opponent2 = new Player2Random();
                    opponent2.Name = "Random Raven";
                    opponent2.GenerateRoshambo();
                    return opponent2;
                    //break;
                case OpponentSelectionEnum.Player3Paper:
                    Player3Paper opponent3 = new Player3Paper();
                    opponent3.Name = "Paper Pete";
                    opponent3.GenerateRoshambo();
                    return opponent3;
                    //break;
                default:
                    return null;
                    //break;
            }
        }

    }
}
