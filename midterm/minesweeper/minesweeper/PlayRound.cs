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
            //String coordinateRegexPattern = @"\d\s\d";

            //Console.Write($"[g]uess [f]lag [u]nflag [s]how [h]ide [q]uit: ");
            Console.WriteLine($"Options: [f]lag, [u]nflag, [s]how, [h]ide, [q]uit: ");
            Console.Write("Guess [x y] or option: ");
            var userEntry = Console.ReadLine();

            //Match match = Regex.Match(userEntry, coordinateRegexPattern);

            //if (match.Success)
            //{
            //    var userCoordinates = ValidateAndCreateCoordinates(userEntry);
            //    GuessCell(board, userCoordinates);
            //    return true;
            //}
            //else
            {
                switch (userEntry)
                {
                    //add new game option
                    //case "g":
                    //    GuessCell(board, EnterAndValidateCellCoordinates(board));
                    //    return true;
                    case "f":
                        Console.Write("Enter coordinates to flag [x y]: ");
                        FlagCell(board, CaptureAndValidateCoordinates(board, Console.ReadLine()));
                        return true;
                    case "u":
                        Console.Write("Enter coordinates to unflag [x y]: ");
                        UnflagCell(board, CaptureAndValidateCoordinates(board, Console.ReadLine()));
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
                        GuessCell(board, CaptureAndValidateCoordinates(board, userEntry));
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
            UncoverNearbyCells(board, cellGuessed);
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

        public static int[] CaptureAndValidateCoordinates(Board board, string userInput)
        {
            try
            {
                Match match = Regex.Match(userInput, @"\d\s\d");
                String[] stringArry = userInput.Split(' ');
                int[] userCoordinates = new int[2];

                if (match.Success)
                {
                    for (int i = 0; i < userCoordinates.Length; i++)
                    {
                        userCoordinates[i] = int.Parse(stringArry[i]);
                    }
                    return userCoordinates;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input failed");
                Console.ReadLine();
            }

            return null;

            //if (match.Success)
            //{
            //    String[] stringArry = userInput.Split(' ');
            //    int[] userCoordinates = new int[2];
            //    for (int i = 0; i < userCoordinates.Length; i++)
            //    {
            //        userCoordinates[i] = int.Parse(stringArry[i]);
            //    }
            //    return userCoordinates;
            //}
            //else
            //{
            //    return null;
            //}
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

            var cellsToSearchAround = new List<Cell>();
            var cellListToMakeVisible = new List<Cell>();
            cellsToSearchAround.Add(userCellGuess);


            var cellSurroundingQueue = new Queue<Cell>();
            if (userCellGuess.UserGuessed == false)
            {
            }
            cellSurroundingQueue = Board.GetSurroundingCells(board, userCellGuess);

            while (cellSurroundingQueue.Count > 0)
            {
                //for (int i = 0; i < cellsToSearchAround.Count; i++)
                //{
                //    for (int x = cellsToSearchAround[i].XCoordinate - 1; x <= cellsToSearchAround[i].XCoordinate + 1; x++)
                //    {
                //        for (int y = cellsToSearchAround[i].YCoordinate - 1; y <= cellsToSearchAround[i].YCoordinate + 1; y++)
                //        {
                //            if (x >= 0 && y >= 0 && x < board.BoardSize && y < board.BoardSize && board.BoardArray[x, y].IsMine == false && board.BoardArray[x, y].UserGuessed == false)
                //            {
                //                cellListToMakeVisible.Add(board.BoardArray[x, y]);
                //            }
                //        }
                //    }
                //}
                var cellQueueToMakeVisible = new Queue<Cell>();

                var shouldCellBeMadeVisible = cellSurroundingQueue.Dequeue();
                if (shouldCellBeMadeVisible.IsMine == false && shouldCellBeMadeVisible.UserGuessed == false)
                {
                    cellQueueToMakeVisible.Enqueue(shouldCellBeMadeVisible);
                }

                //cellsToSearchAround.Clear();
                var tempQueue = new Queue<Cell>();
                while (cellQueueToMakeVisible.Count > 0)
                {
                    var cellToMakeVisible = cellQueueToMakeVisible.Dequeue();

                    if (cellToMakeVisible.ProximityCounter == 0)
                    {
                        tempQueue = Board.GetSurroundingCells(board, cellToMakeVisible);
                        cellToMakeVisible.UserGuessed = true;
                    }
                }

                while (tempQueue.Count > 0)
                {
                    cellSurroundingQueue.Enqueue(tempQueue.Dequeue());
                }

                //foreach (var cell in cellListToMakeVisible)
                //{
                //    if (cell.ProximityCounter == 0)
                //    {
                //        cellsToSearchAround.Add(cell);
                //    }
                //}

                //foreach (var cell in cellListToMakeVisible)
                //{
                //    cell.UserGuessed = true;
                //}

                //cellListToMakeVisible.Clear();

            }


            foreach (var cell in cellListToMakeVisible)
            {
                Console.WriteLine($"{cell.XCoordinate}, {cell.YCoordinate}");
            }
            Console.WriteLine();
            foreach (var cell in cellsToSearchAround)
            {
                Console.WriteLine($"{cell.XCoordinate}, {cell.YCoordinate}");

            }

        }
    }
}
