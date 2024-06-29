using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Models
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Initial Catalog=Escuela;User ID=DB_Sinche;Password=admin123;trustservercertificate=True");
        }
    }
}
