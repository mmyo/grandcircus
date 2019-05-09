using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Triangle : ShapeBase
    {
        public double Length1 { get; set; }

        public double Length2 { get; set; }

        public double Length3 { get; set; }


        public override double GetArea()
        {
            double s = ((Length1 + Length2 + Length3) / 2);
            return Math.Sqrt(s * (s - Length1) * (s - Length2) * (s - Length3) );
        }

        public override double GetPerimeter()
        {
            return Length1 + Length2 + Length3;
        }
    }
}
