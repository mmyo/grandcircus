﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class Player3Paper : PlayerBase, IPlayer
    {
        public  Enum GenerateRoshambo()
        {
            Roshambo = RoshamboEnum.Paper;
            return Roshambo;
        }
    }
}
