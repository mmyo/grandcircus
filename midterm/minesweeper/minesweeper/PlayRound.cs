using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace minesweeper
{
    public class PlayRound
    {
        public static bool UserMenu(Board board, GameSettings settings)
        {
            String coordinateRegexPattern = @"\d\s\d";

            //Console.Write($"[g]uess [f]lag [u]nflag [s]how [h]ide [q]uit: ");
            Console.WriteLine($"Guess [x y], [f]lag, [u]nflag, [s]how, [h]ide, [q]uit: ");

            var userEntry = Console.ReadLine();

            Match match = Regex.Match(userEntry, coordinateRegexPattern);

            if (match.Success)
            {
                var userCoordinates = ValidateAndCreateCoordinates(userEntry);
                GuessCell(board, userCoordinates);
                return true;
            }
            else
            {
                switch (userEntry)
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
                        settings.RevealBoard = true;
                        return true;
                    case "h":
                        settings.RevealBoard = false;
                        return true;
                    case "q":
                        settings.RevealBoard = true;
                        return false;
                    default:
                        return true;
                }
            }


        }

        public static int[] EnterAndValidateCellCoordinates(Board board)
        {
            int[] userCoordinates = new int[2];

            try
            {
                Console.Write("X: ");
                userCoordinates[0] = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Y: ");
                userCoordinates[1] = int.Parse(Console.ReadLine()) - 1;
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
            //UncoverNearbyCells(board, cellGuessed);
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

        public static int[] ValidateAndCreateCoordinates(string userInput)
        {

            String[] stringArry = userInput.Split(' ');
            int[] userCoordinates = new int[2];
            for (int i = 0; i < userCoordinates.Length; i++)
            {
                userCoordinates[i] = int.Parse(stringArry[i]) - 1;
            }
            return userCoordinates;
        }

        public static void FlagCell(Board board, int[] userEntry)
        {
            board.BoardArray[userEntry[0], userEntry[1]].IsFlaggedByUser = true;
        }

        public static void UnflagCell(Board board, int[] userEntry)
        {
            board.BoardArray[userEntry[0], userEntry[1]].IsFlaggedByUser = false;
        }

        public static bool EvaluateIfUserWon(Board board)
        {
            //not working yet
            var countOfMinesFlagged = 0;
            var countOfCellsMisflagged = 0;

            foreach (var cell in board.ListOfMines)
            {
                if (cell.IsFlaggedByUser == true)
                {
                    countOfMinesFlagged++;
                }
            }
            foreach (var cell in board.BoardArray)
            {
                if (cell.IsFlaggedByUser == true && cell.IsMine == false)
                {
                    countOfCellsMisflagged++;
                }
            }

            if (countOfMinesFlagged == board.ListOfMines.Count && countOfCellsMisflagged == 0)
            {
                return true;
            }

            return false;
        }

        public static void UncoverNearbyCells(Board board, Cell userCellGuess)
        {
            //add first cell to List<cell>
            //loop through cells in list
            //set cell.isvisible=true 
            //move +/-1 in each direction. if cell.ismine=false && cell.proximitycounter>0 then set cell.isvisible=true and add to new List<cell>

            var cellListToUncover = new List<Cell>();
            cellListToUncover.Add(userCellGuess);

            do
            {
                foreach (var cell in cellListToUncover)
                {
                    cell.UserGuessed = true;
                }

                for (int i = 0; i < cellListToUncover.Count; i++)
                {
                    for (int x = cellListToUncover[i].XCoordinate - 1; x <= cellListToUncover[i].XCoordinate + 1; x++)
                    {
                        for (int y = cellListToUncover[x].YCoordinate - 1; y <= cellListToUncover[x].YCoordinate + 1; y++)
                        {
                            if (x >= 0 && y >= 0 && x < board.BoardSize && y < board.BoardSize && board.BoardArray[x, y].IsMine != true)
                            {
                                cellListToUncover.Add(board.BoardArray[x, y]);
                            }
                        }
                    }
                }


            } while (cellListToUncover.Count > 0);

        }
    }
}
