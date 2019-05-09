using System;
using System.Collections.Generic;
using System.Text;

namespace exercise52
{
    public abstract class ShapeBase : IArea, IPerimeter
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

    }
}
