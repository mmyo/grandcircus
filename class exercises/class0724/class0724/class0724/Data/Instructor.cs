using System.Collections.Generic;

namespace class0724.Data
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        // virtual allows lazy loading of instructors

    }
}