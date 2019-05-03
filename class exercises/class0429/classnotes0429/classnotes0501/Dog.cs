using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501
{
    public abstract class DogBase : AnimalBase
    {
        public DogBase(string name, int age, string color)
        {
            Name = name;
            Age = age;
        }

        public string Color { get; set; }

        public virtual string Bark()
        {
            return "woof!";
        }

        protected string Howl()
        {
            return "awooooo";
        }

        private void MakeMess()
        {
            //make a mess
        }
    }
}
