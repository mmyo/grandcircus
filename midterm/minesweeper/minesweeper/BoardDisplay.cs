using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class BoardDisplay
    {
        public static void DisplayBoardSettings(Board board, GameSettings settings)
        {
            Console.WriteLine($"{settings.DifficultyLevel}  |  {board.BoardArray.GetLength(0)} x {board.BoardArray.GetLength(1)}  |  {board.NumberOfMines} total mines\n");

        }

        public static void DisplayBoard(Board board, GameSettings settings)
        {
            Console.Clear();

            if (settings.DebugMode == true)
            {
                DisplayBoardSettings(board, settings);
                DisplayEntireBoard(board);
                Console.WriteLine();
            }

            DisplayBoardSettings(board, settings);

            for (int i = board.BoardArray.GetLength(0) - 1; i >= 0; i--)
            {
                Console.BackgroundColor = ConsoleColor.White;

                for (int j = 0; j < board.BoardArray.GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.White;

                    var currentCell = board.BoardArray[j, i];
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

        public static void DisplayEntireBoard(Board board)
        {

            for (int i = board.BoardArray.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < board.BoardArray.GetLength(1); j++)
                {
                    var currentCell = board.BoardArray[j, i];
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
                Console.Write(Environment.NewLine);
            }
        }
    }
}
