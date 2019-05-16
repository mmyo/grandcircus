using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class RoshamboApp
    {
        public static void Run()
        {
            //var winnersList = new List<PlayerBase>();
            var playerUser = new PlayerUser();
            playerUser = PlayerSelectionMenu.DisplayMenu();
            playerUser.ThingsICanBeat = DetermineWhatICanBeat(playerUser);

            Console.WriteLine();
            var opponent = OpponentSelectionMenu.CreateOpponent(OpponentSelectionMenu.DisplayMenu());

            Console.WriteLine();

            EvaluateWinner(playerUser, opponent);
    
        }

        public static void PlayRound(PlayerBase user)
        {
            switch (OpponentSelectionMenu.DisplayMenu())
            {
                case OpponentSelectionEnum.Player1Rock:
                    Player1Rock opponent = new Player1Rock();
                    opponent.GenerateRoshambo();
                    opponent.Name = "Rocky Rock";
                    EvaluateWinner(user, opponent);
                    break;
                case OpponentSelectionEnum.Player2Random:
                    Player2Random opponent2 = new Player2Random();
                    opponent2.Name = "Random Raven";
                    opponent2.GenerateRoshambo();
                    EvaluateWinner(user, opponent2);
                    break;
                case OpponentSelectionEnum.Player3Paper:
                    Player3Paper opponent3 = new Player3Paper();
                    opponent3.Name = "Paper Pete";
                    opponent3.GenerateRoshambo();
                    EvaluateWinner(user, opponent3);
                    break;
                default:
                    break;
            }
        }

        public static void EvaluateWinner(PlayerBase player1, PlayerBase opponent)
        {

            if (player1.Roshambo.Equals(opponent.Roshambo))
            {
                Console.WriteLine($"You: {player1.Roshambo}");
                Console.WriteLine($"Opponent: {opponent.Roshambo}");
                Console.WriteLine("tie");
                return;
            }
            else
            {
                foreach (var whatICanBeat in player1.ThingsICanBeat)
                {
                    if (whatICanBeat.Equals(opponent.Roshambo))
                    {
                        Console.WriteLine($"You: {player1.Roshambo}");
                        Console.WriteLine($"Opponent: {opponent.Roshambo}");
                        Console.WriteLine($"You win!");
                        return;
                    }
                }
            }          

            Console.WriteLine($"You: {player1.Roshambo}");
            Console.WriteLine($"Opponent: {opponent.Roshambo}");
            Console.WriteLine($"Computer wins");

        }

        public static List<Enum> DetermineWhatICanBeat(PlayerBase player)
        {
            var iCanBeatTheseList = new List<Enum>();

            switch (player.Roshambo)
            {
                case RoshamboEnum.Rock:
                    iCanBeatTheseList.Add(RoshamboEnum.Scissors);
                    iCanBeatTheseList.Add(RoshamboEnum.Lizard);    
                    break;
                case RoshamboEnum.Paper:
                    iCanBeatTheseList.Add(RoshamboEnum.Rock);
                    iCanBeatTheseList.Add(RoshamboEnum.Spock);
                    break;
                case RoshamboEnum.Scissors:
                    iCanBeatTheseList.Add(RoshamboEnum.Paper);
                    iCanBeatTheseList.Add(RoshamboEnum.Lizard);
                    break;
                case RoshamboEnum.Lizard:
                    iCanBeatTheseList.Add(RoshamboEnum.Spock);
                    iCanBeatTheseList.Add(RoshamboEnum.Paper);
                    break;
                case RoshamboEnum.Spock:
                    iCanBeatTheseList.Add(RoshamboEnum.Scissors);
                    iCanBeatTheseList.Add(RoshamboEnum.Rock);
                    break;
                default:
                    break;
            }

            return iCanBeatTheseList;
        }

        public static void Test()
        {
            Player1Rock player1 = new Player1Rock();
            Console.WriteLine(player1.Roshambo);

            Player2Random player2 = new Player2Random();

            Console.Write($"Player1: {player1.GenerateRoshambo()}, Player2: {player2.Roshambo = RoshamboEnum.Scissors} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.Roshambo = RoshamboEnum.Paper}, Player2: {player2.Roshambo = RoshamboEnum.Rock} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.GenerateRoshambo()}, Player2: {player2.Roshambo = RoshamboEnum.Paper} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.Roshambo = RoshamboEnum.Scissors}, Player2: {player2.Roshambo = RoshamboEnum.Rock} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.GenerateRoshambo()}, Player2: {player2.Roshambo = RoshamboEnum.Rock} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.Roshambo = RoshamboEnum.Paper}, Player2: {player2.Roshambo = RoshamboEnum.Paper} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);

            Console.Write($"Player1: {player1.Roshambo = RoshamboEnum.Scissors}, Player2: {player2.Roshambo = RoshamboEnum.Scissors} ... ");
            RoshamboApp.EvaluateWinner(player1, player2);
        }
    }

}
