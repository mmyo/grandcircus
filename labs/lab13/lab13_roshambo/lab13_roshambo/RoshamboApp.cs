using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class RoshamboApp
    {
        public static void Run()
        {
            var winnersList = new List<PlayerBase>();
            var playerUser = new PlayerUser();
            playerUser = PlayerSelectionMenu.DisplayMenu();
            //PlayRound(playerUser);
            //var selectedOpponent = OpponentSelectionMenu.DisplayMenu();
            var opponent = OpponentSelectionMenu.CreateOpponent(OpponentSelectionMenu.DisplayMenu());
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

        public static void EvaluateWinner(PlayerBase player1, PlayerBase player2)
        {
            if (player1.Roshambo.Equals(player2.Roshambo))
            {
                Console.WriteLine($"{player1.Name}: {player1.Roshambo}, \n{player2.Name}: {player2.Roshambo}, \ntie");
                player1.TiesCount++;
            }
            else if ((player1.Roshambo.Equals(RoshamboEnum.Rock) && player2.Roshambo.Equals(RoshamboEnum.Scissors)) 
                || (player1.Roshambo.Equals(RoshamboEnum.Paper) && player2.Roshambo.Equals(RoshamboEnum.Rock))
                || (player1.Roshambo.Equals(RoshamboEnum.Scissors) && player2.Roshambo.Equals(RoshamboEnum.Paper)))

            {
                Console.WriteLine($"{player1.Name}: {player1.Roshambo}, \n{player2.Name}: {player2.Roshambo}, \n{player1.Name} wins");

            }
            else if ((player1.Roshambo.Equals(RoshamboEnum.Rock) && player2.Roshambo.Equals(RoshamboEnum.Paper)) 
                || (player1.Roshambo.Equals(RoshamboEnum.Scissors) && player2.Roshambo.Equals(RoshamboEnum.Rock))
                || (player1.Roshambo.Equals(RoshamboEnum.Paper) && player2.Roshambo.Equals(RoshamboEnum.Scissors)))
            {
                Console.WriteLine($"{player1.Name}: {player1.Roshambo}, \n{player2.Name}: {player2.Roshambo}, \n{player2.Name} wins");
            }
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
