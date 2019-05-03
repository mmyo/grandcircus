using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501
{
    class Yorkie : DogBase
    {
        public Yorkie(string name, int age, string color )
            :base (name, age, color)
        {

        }

        public override string Bark()
        {
            //base.Bark();
            return "yip!"; 
        }

    }
}
