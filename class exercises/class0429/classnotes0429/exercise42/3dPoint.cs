using System;
using System.Collections.Generic;
using System.Text;

namespace exercise42
{
    class _3dPoint : PointBase
    {
        public double SecondX { get; set; }

        public double SecondY { get; set; }

        public double CalculateDistance()
        {
            return Math.Sqrt((PointX * PointX) + (PointY * PointY));
        }

        public string CalculateMidpoint()
        {
            var x = (PointX + SecondX) / 2;
            var y = (PointY + SecondY) /2;

            return $"({x} , {y})";
        }
    }

}
