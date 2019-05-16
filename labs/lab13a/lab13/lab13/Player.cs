using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    public abstract class Player
    {
        public string Name { get; set; }

        public Enum Roshambo { get; set; }

        public abstract Enum GenerateRoshambo();
    }
}
