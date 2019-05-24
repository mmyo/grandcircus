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

        public Board()
        {          
                       
        }

        //public void CalcBoardSizeAndNumberOfMines(Enum difficulty)
        //{
        //    switch (difficulty)
        //    {
        //        case DiffcultyLevel.Easy:
        //            //BoardSize = 9;
        //            //NumberOfMines = 10;
        //            BoardSize = 4;
        //            NumberOfMines = 10;
        //            break;
        //        case DiffcultyLevel.Medium:
        //            BoardSize = 16;
        //            NumberOfMines = 40;
        //            break;
        //        case DiffcultyLevel.Hard:
        //            BoardSize = 20;
        //            NumberOfMines = 99;
        //            break;
        //        default:
        //            break;
        //    }
        //}

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
                        Console.Write($"| M ");
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
            //var testMine = new Cell();
            //testMine.XCoordinate = 0;
            //testMine.YCoordinate = 0;
            //testMine.IsMine = true;
            //BoardArray[testMine.XCoordinate, testMine.YCoordinate] = testMine;
            //GenerateProximityCounter(testMine);

            //var testMine2 = new Cell();
            //testMine2.XCoordinate = 1;
            //testMine2.YCoordinate = 0;
            //testMine2.IsMine = true;
            //BoardArray[testMine2.XCoordinate, testMine2.YCoordinate] = testMine2;
            //GenerateProximityCounter(testMine2);

            //var testMine3 = new Cell();
            //testMine3.XCoordinate = 2;
            //testMine3.YCoordinate = 0;
            //testMine3.IsMine = true;
            //BoardArray[testMine3.XCoordinate, testMine3.YCoordinate] = testMine3;
            //GenerateProximityCounter(testMine3);

            //var testMine4 = new Cell();
            //testMine4.XCoordinate = 1;
            //testMine4.YCoordinate = 2;
            //testMine4.IsMine = true;
            //BoardArray[testMine4.XCoordinate, testMine4.YCoordinate] = testMine4;
            //GenerateProximityCounter(testMine4);

        }

        public void GenerateProximityCounter(Cell mine)
        {
            int[] x = new int[8];
            int[] y = new int[8];

            x[0] = mine.XCoordinate - 1;
            y[0] = mine.YCoordinate - 1;

            x[1] = mine.XCoordinate;
            y[1] = mine.YCoordinate - 1;


            x[2] = mine.XCoordinate + 1;
            y[2] = mine.YCoordinate - 1;


            x[3] = mine.XCoordinate - 1;
            y[3] = mine.YCoordinate;


            x[4] = mine.XCoordinate + 1;
            y[4] = mine.YCoordinate;


            x[5] = mine.XCoordinate - 1;
            y[5] = mine.YCoordinate + 1;


            x[6] = mine.XCoordinate;
            y[6] = mine.YCoordinate + 1;


            x[7] = mine.XCoordinate + 1;
            y[7] = mine.YCoordinate + 1;

            try
            {
                BoardArray[x[0], y[0]].ProximityCounter++;
                BoardArray[x[1], y[1]].ProximityCounter++;
                BoardArray[x[2], y[2]].ProximityCounter++;
                BoardArray[x[3], y[3]].ProximityCounter++;
                BoardArray[x[4], y[4]].ProximityCounter++;
                BoardArray[x[5], y[5]].ProximityCounter++;
                BoardArray[x[6], y[6]].ProximityCounter++;
                BoardArray[x[7], y[7]].ProximityCounter++;
            }
            catch (Exception)
            {
                //throw;
            }


            //for (int x = mine.XCoordinate - 1; x <= mine.XCoordinate + 1; x++)
            //{
            //    for (int y = mine.YCoordinate - 1; y <= mine.YCoordinate + 1; y++)
            //    {
            //        if (x >= 0 && y >= 0 && x < BoardSize && y < BoardSize)
            //        {
            //            BoardArray[x, y].ProximityCounter++;
            //        }
            //    }
            //}
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
