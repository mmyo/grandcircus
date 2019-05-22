using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Cell
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public bool isMine { get; set; }
        public int proximityCounter { get; set; }
        public bool isVisible { get; set; }
        public string overrideDiplayValue { get; set; }
        public bool isFlagged { get; set; }
    }
}
