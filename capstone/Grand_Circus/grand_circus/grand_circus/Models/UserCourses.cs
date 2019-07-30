using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grand_circus.Models
{
    public class UserCourses
    {
        [Key]
        public int UserCoursesId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Semester { get; set; }
        public string Grade { get; set; }

    }
}
