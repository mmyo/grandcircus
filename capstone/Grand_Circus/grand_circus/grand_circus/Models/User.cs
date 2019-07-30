﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grand_circus.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Type  { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public ICollection<UserCourses> UserCourses { get; set; }

    }
}
