using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public class Square : IArea, IPerimeter
    {
        public double Side { get; set; }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
