using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Board
    {

        public Cell[,] BoardArray { get; set; }

        public int BoardSize { get; set; }

        public int NumberOfMines { get; set; }

        //public Enum DifficultyLevel { get; set; }

        public Board(Enum difficulty)
        {          
                       
        }

        public void CalcBoardSizeAndNumberOfMines(Enum difficulty)
        {
            switch (difficulty)
            {
                case DiffcultyLevel.Easy:
                    BoardSize = 9;
                    NumberOfMines = 10;
                    break;
                case DiffcultyLevel.Medium:
                    BoardSize = 16;
                    NumberOfMines = 40;
                    break;
                case DiffcultyLevel.Hard:
                    BoardSize = 20;
                    NumberOfMines = 99;
                    break;
                default:
                    break;
            }
        }

        public void PopulateGameBoard()
        {
            BoardArray = new Cell[BoardSize, BoardSize];

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    BoardArray[x, y] = new Cell() { XCoordinate = x, YCoordinate = y }; ;
                }
            }
        }

        public void DisplayEntireBoard()
        {
            for (int i = BoardArray.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < BoardArray.GetLength(1); j++)
                {
                    var currentCell = BoardArray[j, i];
                    if (currentCell.IsMine == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("| M ");
                        Console.ResetColor();
                    }
                    else if (currentCell.ProximityCounter > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write($"| {currentCell.ProximityCounter} ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write($"|   ");
                        Console.ResetColor();

                    }
                    //board[i,j].IsMine == true
                }
                Console.Write(Environment.NewLine);
            }
        }

        public void GenerateProximityCounter(Cell mine)
        {
            for (int x = mine.XCoordinate - 1; x <= mine.XCoordinate + 1; x++)
            {
                for (int y = mine.YCoordinate - 1; y <= mine.YCoordinate + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < BoardSize && y < BoardSize)
                    {
                        BoardArray[x, y].ProximityCounter++;
                    }
                }
            }
        }

        public void GenerateMines()
        {
            Random rand = new Random();

            for (int i = 0; i < NumberOfMines; i++)
            {
                int x = rand.Next(0, BoardSize - 1);
                int y = rand.Next(0, BoardSize - 1);

                BoardArray[x, y].IsMine = true;

                GenerateProximityCounter(BoardArray[x, y]);
            }
        }

        public void DisplayBoard()
        {

            for (int i = BoardArray.GetLength(0) - 1; i >= 0; i--)
            {
                Console.BackgroundColor = ConsoleColor.White;

                for (int j = 0; j < BoardArray.GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.White;

                    var currentCell = BoardArray[j, i];
                    if (currentCell.UserGuessed == true && currentCell.ProximityCounter <= 0 && currentCell.IsMine == false)
                    {

                        Console.ForegroundColor = ConsoleColor.Black;
                        //Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write("| x ");
                        Console.ResetColor();
                    }
                    else if (currentCell.UserGuessed == true && currentCell.ProximityCounter > 0 && currentCell.IsMine == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"| {currentCell.ProximityCounter} ");
                        Console.ResetColor();

                    }
                    else if (currentCell.UserGuessed == true && currentCell.IsMine == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("| M ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|   ");
                        
                    }
                    //board[i,j].IsMine == true
                }
                Console.Write(Environment.NewLine);
            }
            Console.ResetColor();
        }
    }


}
