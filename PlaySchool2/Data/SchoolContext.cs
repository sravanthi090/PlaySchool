using Microsoft.EntityFrameworkCore;
using PlaySchool2.Models;

namespace PlaySchool2.Data
{
    
        public class SchoolContext : DbContext
        {
            public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
            {
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Students> Students { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Course>().ToTable("Course");
                modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
                modelBuilder.Entity<Students>().ToTable("Student");
            }
        }
    }



