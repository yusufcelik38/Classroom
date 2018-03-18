using Classroom.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Data
{
    public class ClassroomContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public ClassroomContext()
            :base("ClassroomDbContext")
        {
            
        }
        //DbSetlerimizin nasıl bir relationa sahip olduğunu entity frameworke bildiriyoruz.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
