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

            int boardMax = 10;
            var board = GenerateGameBoard(boardMax);

            //manually generate some mines
            var listOfMines = new List<Cell>();
            //randomly generate mine coordinates.at board[x,y] set Cell.IsMine=true 
            board[0, 0].IsMine = true; 
            board[1, 1].IsMine = true;
            board[2, 2].IsMine = true;
            board[3, 3].IsMine = true;
            board[5, 5].IsMine = true;


            //calculate proximity to mines
            GenerateProximityCounter(board, board[0, 0]);
            GenerateProximityCounter(board, board[1, 1]);
            GenerateProximityCounter(board, board[2, 2]);
            GenerateProximityCounter(board, board[3, 3]);
            GenerateProximityCounter(board, board[5, 5]);

            DrawBoard(board, false, true);

            bool keepGuessing = true;
            do
            {
                Console.WriteLine("Guess: ");
                Console.Write("X: ");
                var userX = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                var userY = int.Parse(Console.ReadLine());

                GuessCell(board, userX, userY);

                Console.Write("\nGuess again? y/n: ");
                if (Console.ReadLine() == "n")
                {
                    keepGuessing = false;
                }

            } while (keepGuessing == true);


        }

        public static void GenerateGameBoard(Board board, int boardMax)
        {

            for (int x = 0; x < boardMax; x++)
            {

                for (int y = 0; y < boardMax; y++)
                {
                    var cell = new Cell() { XCoordinate = x };
                    cell.YCoordinate = y;
                    board.ListOfCells.Add(cell);
                }

            }
        }

        public static Cell[,] GenerateGameBoard(int boardMax)
        {
            Cell[,] gameBoardArray = new Cell[boardMax, boardMax];

            for (int x = 0; x < boardMax; x++)
            {

                for (int y = 0; y < boardMax; y++)
                {
                    var cell = new Cell() { XCoordinate = x };
                    cell.YCoordinate = y;
                    gameBoardArray[x, y] = cell;
                }

            }

            return gameBoardArray;
        }

        public static void GenerateMines(Cell[,] board, int x, int y)
        {
            foreach (var cell in board)
            {
                if (cell.XCoordinate == 1 && cell.YCoordinate == 1)
                {
                    cell.IsMine = true;
                }
            }
        }

        public static void GenerateProximityCounter(Cell[,] board, Cell mine)
        {

            for (int x = mine.XCoordinate -1 ; x <= mine.XCoordinate + 1 ; x++)
            {
                for (int y = mine.YCoordinate -1 ; y <= mine.YCoordinate + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < board.GetLength(0) && y < board.GetLength(1))
                    {
                        board[x, y].ProximityCounter++;

                    }
                }
            }
        }

        public static void GuessCell(Cell[,] board, int userX, int userY)
        {
            var cellGuessed = board[userX, userY];
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

        public static void DrawBoard(Cell[,] board, bool listAllCoordinates, bool showAll)
        {
            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);

            if (showAll == true)
            {
                for (int i = rowLength - 1; i >= 0; i--)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        var currentCell = board[j, i];
                        if (currentCell.IsMine == true)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" M ");
                            Console.ResetColor();
                        }
                        else if (currentCell.ProximityCounter > 0)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write($" {currentCell.ProximityCounter} ");
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write($"   ");
                            Console.ResetColor();

                        }
                        //board[i,j].IsMine == true
                    }
                    Console.Write(Environment.NewLine);
                }
            }

           
            if (listAllCoordinates.Equals(true))
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        Console.WriteLine($"{board[x, y].XCoordinate}, {board[x, y].YCoordinate}, {board[x, y].IsMine}, {board[x, y].ProximityCounter}");
                    }
                }
            }
        }
 
    }
}
