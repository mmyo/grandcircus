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
            var board = new Board();
            settings.CalcBoardSizeAndNumberOfMines(board);
            board.PopulateGameBoard();
            board.GenerateMines();

            bool keepGuessing = false;
            do
            {
                //Display gameboard
                BoardDisplay.DisplayBoard(board, settings);

                //User guesses
                PlayRound.GuessCell(board, PlayRound.AskUser());

                //Redraw gameboard after guess
                BoardDisplay.DisplayBoard(board, settings);

                Console.Write("\nGuess again? y/n: ");

                if (Console.ReadLine() == "y")
                {
                    keepGuessing = true;
                }

            } while (keepGuessing == true);

        }
 
    }
}
