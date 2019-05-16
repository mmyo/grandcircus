using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class Player1Rock : PlayerBase, IPlayer
    {

        public Enum GenerateRoshambo()
        {
            Roshambo = RoshamboEnum.Rock;
            return Roshambo;
        }

    }
}
