using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace random_teams.Models
{
    public class User
    {
        [Required(ErrorMessage= "Name is required" )]
        public string Name { get; set; }

    }
}
