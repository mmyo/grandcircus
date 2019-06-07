using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class GameSettings
    {

        public Enum DifficultyLevel { get; set; }

        public bool RevealBoard { get; set; }

        public GameSettings()
        {
            DifficultyLevel = DiffcultyLevel.Easy;
            //DifficultyLevel = SetDifficultyLevel();
        }


        public Enum SetDifficultyLevel()
        {
            Console.Write("Difficulty Level? (1,2,3) : ");

            if (Enum.TryParse<DiffcultyLevel>(Console.ReadLine(), out var level))
            {
               return level;
            }
            return null;

        }

        
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

    }
}
