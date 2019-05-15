using System;
using System.Collections.Generic;
using System.Text;

namespace lab13_roshambo
{
    public class Player1Rock : Player
    {
        //Roshambo = RoshamboEnum.Rock;
        //public new Enum Roshambo
        //{
        //    get
        //    {
        //        return Roshambo;
        //    }
        //    set
        //    {
        //        value = RoshamboEnum.Rock;
        //    }
        //}

        //public Enum Roshambo { get; set; } = RoshamboEnum.Rock;


        public override Enum GenerateRoshambo()
        {
            Roshambo = RoshamboEnum.Rock;
            return Roshambo;
        }
    }
}
