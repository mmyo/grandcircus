using System;
using System.Collections.Generic;
using System.Text;

namespace lab13
{
    public class Player1Rock : Player
    {

        public override Enum GenerateRoshambo()
        {
            Roshambo = RoshamboEnum.Rock;
            return Roshambo;
        }
    }
}
