using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public class House : Building
    {
        public override double GetVolume()
        {
            return Length * Width * Height;
        }

        public override double GetFirstFloorArea()
        {
            return Length * Width;
        }
    }
}
