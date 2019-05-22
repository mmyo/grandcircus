using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Board
    {
        public List<Cell> ListOfCells { get; set; }


        public Board()
        {
            ListOfCells = new List<Cell>();
        }

       
    }


}
