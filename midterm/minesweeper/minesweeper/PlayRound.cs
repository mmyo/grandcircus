using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class PlayRound
    {
        public static bool UserMenu(Board board, GameSettings settings)
        {
            Console.Write($"[g]uess [f]lag [u]nflag [s]how [h]ide [q]uit: ");

            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                //add new game option
                case "g":
                    GuessCell(board, EnterAndValidateCellCoordinates(board));
                    return true;
                case "f":
                    FlagCell(board, EnterAndValidateCellCoordinates(board));
                    return true;
                case "u":
                    UnflagCell(board, EnterAndValidateCellCoordinates(board));
                    return true;
                case "s":
                    settings.DebugMode = true;
                    return true;
                case "h":
                    settings.DebugMode = false;
                    return true;
                case "q":
                    settings.DebugMode = true;
                    return false;
                default:
                    return true;
            }
        }

        public static int[] EnterAndValidateCellCoordinates(Board board)
        {
            int[] userCoordinates = new int[2];

            try
            {
                Console.Write("X: ");
                userCoordinates[0] = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                userCoordinates[1] = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You entered something weird. Try again.");
                Console.ReadLine();
            }

            return userCoordinates;
        }

        public static void GuessCell(Board board, int[] userEntry)
        {
            var cellGuessed = board.BoardArray[userEntry[0], userEntry[1]];
            cellGuessed.UserGuessed = true;
            if (cellGuessed.IsMine == true)
            {
                Console.WriteLine("You hit a mine.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Mines nearby: {cellGuessed.ProximityCounter}");
                Console.ReadKey();
            }         
        }

        public static void FlagCell(Board board, int[] userEntry)
        {
            board.BoardArray[userEntry[0], userEntry[1]].IsFlaggedByUser = true;
        }

        public static void UnflagCell(Board board, int[] userEntry)
        {
            board.BoardArray[userEntry[0], userEntry[1]].IsFlaggedByUser = false;
        }

        public static void EvaluateIfUserWon(Board board)
        {
            //not working yet
            foreach (var cell in board.BoardArray)
            {
                if (cell.IsMine == true && cell.IsFlaggedByUser == false)
                {
                    break;
                    //return false;
                }
                if (cell.IsFlaggedByUser == true && cell.IsMine == false)
                {
                    break;
                    //return false;
                }
            }
            Console.WriteLine("You Won!");
            Console.ReadLine();
            //return true;
        }
    }
}
