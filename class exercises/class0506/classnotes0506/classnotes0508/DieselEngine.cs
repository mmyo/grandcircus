using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0508
{
    public class DieselEngine : Engine
    {
        public override void Drive()
        {
            Console.WriteLine("Before drive");
            base.Drive();
            Console.WriteLine("After drive");
        }
    }
}
