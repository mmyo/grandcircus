﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class Player2Random : PlayerBase, IPlayer
    {
        //public Enum Roshambo { get; set; }

        public Enum GenerateRoshambo()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 3);
            Roshambo = (RoshamboEnum)randomNum;
            return Roshambo;
        }
    }
}
