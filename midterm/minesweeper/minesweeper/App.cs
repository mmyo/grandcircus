using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class App
    {
        public static void Game()
        {

            var gameBoard = new Board(SetDifficultyLevel());

            bool keepGuessing = true;
            do
            {
                Console.Clear();
                gameBoard.DisplayEntireBoard();
                Console.WriteLine();
                gameBoard.DisplayBoard();

                Console.WriteLine("Guess: ");
                Console.Write("X: ");
                var userX = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                var userY = int.Parse(Console.ReadLine());

                GuessCell(gameBoard, userX, userY);

                Console.Write("\nGuess again? y/n: ");

                if (Console.ReadLine() == "n")
                {
                    keepGuessing = false;
                }

            } while (keepGuessing == true);

        }

        public static Enum SetDifficultyLevel()
        {

            Console.Write("Difficulty Level? (1,2,3) : ");

            if (Enum.TryParse<DiffcultyLevel>(Console.ReadLine(), out var level))
            {
                return level;
            }
            return null;

        }

        public static void GuessCell(Board board, int userX, int userY)
        {
            var cellGuessed = board.BoardArray[userX, userY];
            cellGuessed.UserGuessed = true;
            if (cellGuessed.IsMine == true)
            {
                Console.WriteLine("You hit a mine");
            }
            else
            {
                Console.WriteLine($"Mines nearby: {cellGuessed.ProximityCounter}");
            }

        }
 
    }
}
