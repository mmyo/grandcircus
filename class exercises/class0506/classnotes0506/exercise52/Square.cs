using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Square : ShapeBase
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
