using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class App
    {
        public static void Game()
        {
            //var gameBoard = new Board();
            //GenerateGameBoard(gameBoard, 4);

            int boardMax = 4;
            var board = GenerateGameBoardArray(boardMax);

            //manually generate some mines
            GenerateProximityCounter(board, board[1, 1]);
            GenerateProximityCounter(board, board[2, 3]);
            GenerateProximityCounter(board, board[1, 0]);


            for (int x = 0; x < boardMax; x++)
            {
                for (int y = 0; y < boardMax; y++)
                {
                    Console.WriteLine($"{board[x,y].xCoordinate}, {board[x, y].yCoordinate}, {board[x,y].isMine}, {board[x, y].proximityCounter}");
                }
            }

            DrawBoard(board);

        }

        public static void GenerateGameBoard(Board board, int boardMax)
        {

            for (int x = 0; x < boardMax; x++)
            {

                for (int y = 0; y < boardMax; y++)
                {
                    var cell = new Cell() { xCoordinate = x };
                    cell.yCoordinate = y;
                    board.ListOfCells.Add(cell);
                }

            }
        }

        public static Cell[,] GenerateGameBoardArray(int boardMax)
        {
            Cell[,] gameBoardArray = new Cell[boardMax, boardMax];

            for (int x = 0; x < boardMax; x++)
            {

                for (int y = 0; y < boardMax; y++)
                {
                    var cell = new Cell() { xCoordinate = x };
                    cell.yCoordinate = y;
                    gameBoardArray[x, y] = cell;
                }

            }

            return gameBoardArray;
        }

        public static void GenerateMines(Cell[,] board, int x, int y)
        {
            foreach (var cell in board)
            {
                if (cell.xCoordinate == 1 && cell.yCoordinate == 1)
                {
                    cell.isMine = true;
                }
            }
        }

        public static void GenerateProximityCounter(Cell[,] board, Cell mine)
        {

            for (int x = mine.xCoordinate -1 ; x <= mine.xCoordinate + 1 ; x++)
            {
                for (int y = mine.yCoordinate -1 ; y <= mine.yCoordinate + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < board.GetLength(0) && y < board.GetLength(1))
                    {
                        board[x, y].proximityCounter++;

                    }
                }
            }
        }

        public static void GuessCell(Cell[,] board)
        {

        }

        public static void DrawBoard(Cell[,] board)
        {
            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write($"X ");
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadLine();
        }

  

    }
}
