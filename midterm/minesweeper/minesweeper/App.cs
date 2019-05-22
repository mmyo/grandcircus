using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class App
    {
        public static void Game()
        {
            var gameBoard = new Board();
            GenerateGameBoard(gameBoard, 4);

            foreach (var item in gameBoard.ListOfCells)
            {
                Console.WriteLine($"{item.xCoordinate}, {item.yCoordinate}");
            }
        }

        public static void GenerateGameBoard(Board board, int boardMax)
        {

            for (int x = 0; x < boardMax; x++)
            {
                var cell = new Cell() { xCoordinate = x };

                for (int y = 0; y < boardMax; y++)
                {
                    cell.yCoordinate = y;
                    board.ListOfCells.Add(cell);
                }

            }
        }

    }
}
