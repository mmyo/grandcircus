using System;
using System.Collections.Generic;
using System.Text;

namespace exercise42
{
    class Point
    {
        public double X { set; get; }

        public double Y { set; get; }

        public double CalculateDistance()
        {
            return Math.Sqrt( (X * X) + (Y * Y) );
            
        }
    }
}
