using Microsoft.EntityFrameworkCore;

namespace EFCore_SQLite_WinForms.Models
{
    public class ModelContext : DbContext
    {

        public DbSet<Student> students { get; set; }
        public DbSet<School> schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=SchoolStudent.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                new School { schoolId = 1, name = "평택초" },
                new School { schoolId = 2, name = "아산초" },
                new School { schoolId = 3, name = "천안초" },
                new School { schoolId = 4, name = "서정초" });

            modelBuilder.Entity<Student>().HasData(
                new Student { studentId = 1, schoolId = 1, name = "베트맨" },
                new Student { studentId = 2, schoolId = 1, name = "슈퍼맨" },
                new Student { studentId = 3, schoolId = 1, name = "아이언맨" },
                new Student { studentId = 4, schoolId = 2, name = "이연준" },
                new Student { studentId = 5, schoolId = 2, name = "윤석열" },
                new Student { studentId = 6, schoolId = 3, name = "홍길동" },
                new Student { studentId = 7, schoolId = 3, name = "이순신" },
                new Student { studentId = 8, schoolId = 3, name = "이연준" },
                new Student { studentId = 9, schoolId = 4, name = "차범근" },
                new Student { studentId = 10, schoolId = 4, name = "차두리" },
                new Student { studentId = 11, schoolId = 4, name = "손흥민" });
        }
    }
}
