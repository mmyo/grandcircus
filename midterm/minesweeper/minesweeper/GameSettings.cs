using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class GameSettings
    {
        public GameSettings()
        {
            DifficultyLevel = SetDifficultyLevel();
        }

        public Enum DifficultyLevel { get; set; }

        public Enum SetDifficultyLevel()
        {
            Console.Write("Difficulty Level? (1,2,3) : ");

            if (Enum.TryParse<DiffcultyLevel>(Console.ReadLine(), out var level))
            {
                return level;
            }
            return null;

        }

        public bool DebugMode { get; set; }
        
        public void CalcBoardSizeAndNumberOfMines(Board board)
        {
            switch (DifficultyLevel)
            {
                case DiffcultyLevel.Easy:
                    board.BoardSize = 9;
                    board.NumberOfMines = 10;
                    break;
                case DiffcultyLevel.Medium:
                    board.BoardSize = 16;
                    board.NumberOfMines = 40;
                    break;
                case DiffcultyLevel.Hard:
                    board.BoardSize = 20;
                    board.NumberOfMines = 99;
                    break;
                default:
                    break;
            }
        }

        public void GenerateMines(Board board)
        {
            Random rand = new Random();

            for (int i = 0; i < board.NumberOfMines; i++)
            {
                int x = rand.Next(0, board.BoardSize - 1);
                int y = rand.Next(0, board.BoardSize - 1);

                board.BoardArray[x, y].IsMine = true;

                GenerateProximityCounter(board, board.BoardArray[x, y]);
            }
        }

        public void GenerateProximityCounter(Board board, Cell mine)
        {
            for (int x = mine.XCoordinate - 1; x <= mine.XCoordinate + 1; x++)
            {
                for (int y = mine.YCoordinate - 1; y <= mine.YCoordinate + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < board.BoardSize && y < board.BoardSize)
                    {
                        board.BoardArray[x, y].ProximityCounter++;
                    }
                }
            }
        }
    }
}
