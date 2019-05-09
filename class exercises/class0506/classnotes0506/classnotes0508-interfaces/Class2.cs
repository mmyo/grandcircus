using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0508_interfaces
{
    public class Car : IHonk, IBrake
    {
        public string Honk()
        {
            return "honk";
        }

        public void Brake()
        {
            Console.WriteLine("scrrr");
        }
    }
}
