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

            bool keepPlaying = true;
            do
            {
                //Display gameboard
                BoardDisplay.DisplayBoard(board, settings);

                keepPlaying = PlayRound.UserMenu(board, settings);

                //Redraw gameboard after UserMenu selection
                BoardDisplay.DisplayBoard(board, settings);

                if (PlayRound.EvaluateIfUserWon(board))
                {
                    settings.RevealBoard = true;
                    BoardDisplay.DisplayBoard(board, settings);
                    Console.WriteLine("You won!");
                    keepPlaying = false;
                }


            } while (keepPlaying == true);

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();

        }
 
    }
}
