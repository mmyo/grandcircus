using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class PlayRound
    {

        public static int[] AskUser()
        {
            int[] userCoordinates = new int[2];

            Console.WriteLine("Guess: ");
            Console.Write("X: ");
            userCoordinates[0] = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            userCoordinates[1] = int.Parse(Console.ReadLine());

            return userCoordinates;
           
        }

        public static void GuessCell(Board board, int[] userGuess)
        {
            var cellGuessed = board.BoardArray[userGuess[0], userGuess[1]];
            cellGuessed.UserGuessed = true;
            if (cellGuessed.IsMine == true)
            {
                Console.WriteLine("You hit a mine.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Mines nearby: {cellGuessed.ProximityCounter}");
                Console.ReadKey();

            }

        }
    }
}
