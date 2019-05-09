using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Square : ShapeBase
    {
        public double Side { get; set; }

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
