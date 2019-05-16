using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public abstract class PlayerBase 
    {
        public string Name { get; set; }

        public Enum Roshambo { get; set; }

        public int WinsCount { get; set; }

        public int LossesCount { get; set; }

        public int TiesCount { get; set; }


    }
}
