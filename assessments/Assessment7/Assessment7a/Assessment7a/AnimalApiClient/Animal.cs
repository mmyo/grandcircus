using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7a.AnimalApiClient
{
    public class Animal
    {

        public int id { get; set; }
        public string name { get; set; }
        public float weight { get; set; }
        public string diet { get; set; }
        public string habitat { get; set; }

        public Species species { get; set; }

    }
    public class Species
    {
        public string name { get; set; }
        public string _ref { get; set; }
    }
}
