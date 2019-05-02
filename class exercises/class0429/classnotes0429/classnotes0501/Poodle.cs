using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501
{
    public class Poodle : DogBase
    {
        public Poodle(string name, int age, bool isFurTangled)
            :base(name, age)
        {
            IsFurTangled = isFurTangled;
        }

        public bool IsFurTangled { get; set; }

        public string MakeNoise()
        {
            return Howl();
        }
    }
}
