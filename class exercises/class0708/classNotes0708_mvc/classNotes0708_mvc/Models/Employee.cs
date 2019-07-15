using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace classNotes0708_mvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }




    }
}
