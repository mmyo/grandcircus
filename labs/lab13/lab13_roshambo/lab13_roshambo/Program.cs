using System;

namespace lab13_roshambo
{
    class Program
    {
        static void Main(string[] args)
        {

            Player1Rock player1 = new Player1Rock();
            Console.WriteLine(player1.Roshambo);

            Player2Random player2 = new Player2Random();

            Console.Write($"Player1: {player1.GenerateRoshambo()}, Player2: {player2.Roshambo=RoshamboEnum.Scissors} ... ");
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

            Console.ReadLine();
        }


    }
}
