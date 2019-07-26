using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class0724.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }


        public Instructor Instructor { get; set; }

    }
}
