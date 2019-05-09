using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Circle : ShapeBase
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
