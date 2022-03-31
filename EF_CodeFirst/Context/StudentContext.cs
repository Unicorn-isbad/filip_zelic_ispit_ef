using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Models;

namespace EF_CodeFirst.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student { StudentID = 1, StudentName = "Marky Mark", DateOfBirth = DateTime.Now, Height = 1.80m, Weight = 79 },
                                                   new Student { StudentID = 2, StudentName = "Barbie Rossberg", DateOfBirth = DateTime.Now, Height = 1.68m , Weight = 66 });
            modelBuilder.Entity<Grade>().HasData(new Grade { GradeId = 1, GradeName = "Essay" , Section = "", StudentId = 1 },
                                                 new Grade { GradeId = 2, GradeName = "Vocabulary" , Section = "", StudentId = 2 },
                                                 new Grade { GradeId = 3, GradeName = "Grammar" , Section = "", StudentId = 1 },
                                                 new Grade { GradeId = 4, GradeName = "Homework" , Section = "", StudentId = 1 },
                                                 new Grade { GradeId = 5, GradeName = "Project" , Section = "", StudentId = 2 },
                                                 new Grade { GradeId = 6, GradeName = "Quiz" , Section = "", StudentId = 1 },
                                                 new Grade { GradeId = 7, GradeName = "Test" , Section = "", StudentId = 2 });
        }

    }
}
