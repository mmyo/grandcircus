using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Circle : IArea, IPerimeter
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
