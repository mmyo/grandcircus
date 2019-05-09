using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0508
{
    public class DieselEngineChild : DieselEngine
    {
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("Diesel child");
        }


    }
}
