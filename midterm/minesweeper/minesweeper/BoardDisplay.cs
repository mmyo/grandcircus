using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class BoardDisplay
    {
        public static void DisplayBoardSettings(Board board, GameSettings settings)
        {
            Console.WriteLine($"{settings.DifficultyLevel}  |  {board.BoardArray.GetLength(0)} x {board.BoardArray.GetLength(1)}  |  {board.NumberOfMines} total mines");
        }

        public static void DisplayBoard(Board board, GameSettings settings)
        {
            Console.Clear();
            DisplayBoardSettings(board, settings);


            if (settings.RevealBoard == true)
            {
                DisplayRevealedBoard(board);
                Console.WriteLine();
            }

            for (int boardLength = board.BoardArray.GetLength(0) - 1; boardLength >= 0; boardLength--)
            {
                Console.BackgroundColor = ConsoleColor.White;

                for (int boardHeight = 0; boardHeight < board.BoardArray.GetLength(1); boardHeight++)
                {
                    Console.BackgroundColor = ConsoleColor.White;

                    var currentCell = board.BoardArray[boardHeight, boardLength];
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
                    else if (currentCell.IsFlaggedByUser == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("| f ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|   ");

                    }
                    //Console.Write($" { boardHeight + 1}");

                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" { boardLength + 1}");
                Console.ResetColor();

                Console.Write(Environment.NewLine);
            }

            Console.ResetColor();

        }

        public static void DisplayRevealedBoard(Board board)
        {

            for (int boardLength = board.BoardArray.GetLength(0) - 1; boardLength >= 0; boardLength--)
            {
                for (int boardHeight = 0; boardHeight < board.BoardArray.GetLength(1); boardHeight++)
                {
                    var currentCell = board.BoardArray[boardHeight, boardLength];
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
                        Console.ForegroundColor = ConsoleColor.Gray;
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
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($" { boardLength + 1}");
                Console.ResetColor();

                Console.Write(Environment.NewLine);
            }
        }
    }
}
