using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public class Pyramid : Building
    {
        public override double GetVolume()
        {
            return (Length * Width * Height) / 3;

        }
        public override double GetFirstFloorArea()
        {
            return Length * Width;
        }
    }
}
