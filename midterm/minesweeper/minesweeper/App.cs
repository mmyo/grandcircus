using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class App
    {
        public static void Game()
        {
            
            var settings = new GameSettings();
            var board = new Board(settings.DifficultyLevel);
            settings.CalcBoardSizeAndNumberOfMines(settings.DifficultyLevel, board);
            board.PopulateGameBoard();
            board.GenerateMines();

            bool keepGuessing = false;
            do
            {
                //Display gameboard
                Console.Clear();
                board.DisplayEntireBoard();
                Console.WriteLine();
                board.DisplayBoard();

                //User guesses
                PlayRound.GuessCell(board, PlayRound.AskUser());

                //Redraw gameboard
                Console.Clear();
                board.DisplayEntireBoard();
                Console.WriteLine();
                board.DisplayBoard();

                Console.Write("\nGuess again? y/n: ");

                if (Console.ReadLine() == "y")
                {
                    keepGuessing = true;
                }

            } while (keepGuessing == true);

        }
 
    }
}
