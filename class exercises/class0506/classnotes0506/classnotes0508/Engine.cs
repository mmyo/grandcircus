using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0508
{
    public class Engine
    {
        public int HorsePower { get; set; }

        public virtual void Drive()
        {
            //we do some driving
            Console.WriteLine("Engine");

        }

    }
}
