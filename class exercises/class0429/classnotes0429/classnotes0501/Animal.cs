using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
