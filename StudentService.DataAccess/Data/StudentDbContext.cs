using Microsoft.EntityFrameworkCore;
using StudentService.Models;
using System.Text.Json;

namespace StudentService.DataAccess.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) 
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //   .HasOne(s => s.Course)
            //   .WithMany(c => c.Students)
            //   .HasForeignKey(s => s.CourseId);

            
            modelBuilder.Entity<Student>()
               .HasMany(s => s.Courses)
               .WithOne(s => s.Student)
               .HasForeignKey(s => s.StudentId);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
