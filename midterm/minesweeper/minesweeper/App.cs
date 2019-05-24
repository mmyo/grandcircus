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
            //Console.WriteLine(board.BoardSize);
            //Console.WriteLine(board.BoardArray.GetLength(0));
            //Console.WriteLine(board.BoardArray.LongLength);
            //Console.ReadLine();
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
