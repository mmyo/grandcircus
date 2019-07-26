using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class0724.Data
{
    public class ClassroomContext : DbContext
    {
        public ClassroomContext(DbContextOptions<ClassroomContext> options) 
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
