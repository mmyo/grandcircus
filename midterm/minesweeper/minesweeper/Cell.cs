using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Cell
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public bool IsMine { get; set; }
        public int ProximityCounter { get; set; }
        public bool UserGuessed { get; set; }
        public string OverrideDisplayValue { get; set; }
        public bool IsFlaggedByUser { get; set; }

        public Cell()
        {
            IsMine = false;
        }
    }
}
