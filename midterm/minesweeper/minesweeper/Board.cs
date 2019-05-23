using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Board
    {
        public List<Cell> ListOfCells { get; set; }

        public Cell[,] BoardArray { get; set; }

        public int BoardSize { get; set; }

        public Board(int boardSize)
        {
            //ListOfCells = new List<Cell>();
            BoardSize = boardSize;
        }
       
    }


}
