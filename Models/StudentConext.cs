using Microsoft.EntityFrameworkCore;

namespace ProjectAuthentication.Models
{
    public class StudentConext:DbContext
    {
        public StudentConext(DbContextOptions<StudentConext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(a => a.Course)
                .WithMany(b => b.Students)
                .HasForeignKey(c => c.CourseId);
        }
    }
}
