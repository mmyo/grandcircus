using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public abstract class Player
    {
        public string Name { get; set; }

        public Enum Roshambo { get; set; }

        public abstract Enum GenerateRoshambo();

    }
}
