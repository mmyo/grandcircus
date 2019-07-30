using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grand_circus.Models
{
    public class GrandCircusContext : DbContext
    {
        public GrandCircusContext(DbContextOptions<GrandCircusContext> options)
            : base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<User> User { get; set; }

        public DbSet<UserCourses> UserCourses { get; set; }
    }
}
