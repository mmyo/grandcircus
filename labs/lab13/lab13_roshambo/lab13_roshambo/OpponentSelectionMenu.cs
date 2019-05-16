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
                    opponent.Name = "Rocky Rock";
                    opponent.GenerateRoshambo();
                    opponent.ThingsICanBeat = RoshamboApp.DetermineWhatICanBeat(opponent);
                    return opponent;
                    //break;
                case OpponentSelectionEnum.Player2Random:
                    Player2Random opponent2 = new Player2Random();
                    opponent2.Name = "Random Raven";
                    opponent2.GenerateRoshambo();
                    opponent2.ThingsICanBeat = RoshamboApp.DetermineWhatICanBeat(opponent2);
                    return opponent2;
                    //break;
                case OpponentSelectionEnum.Player3Paper:
                    Player3Paper opponent3 = new Player3Paper();
                    opponent3.Name = "Paper Pete";
                    opponent3.GenerateRoshambo();
                    opponent3.ThingsICanBeat = RoshamboApp.DetermineWhatICanBeat(opponent3);
                    return opponent3;
                    //break;
                default:
                    return null;
                    //break;
            }
        }

    }
}
