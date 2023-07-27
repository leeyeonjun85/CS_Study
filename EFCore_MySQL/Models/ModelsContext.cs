using Microsoft.EntityFrameworkCore;
using Oracle_EFCore.Models;

namespace EFCore_MySQL.Models
{
    public class ModelsContext : DbContext
    {
        // DbSet
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }

        string connString = "Server=localhost;Database=testdb;Uid=root;Pwd=0316165110;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(connString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                new School { Id = 1, Name = "평택초" },
                new School { Id = 2, Name = "아산초" },
                new School { Id = 3, Name = "천안초" },
                new School { Id = 4, Name = "서정초" });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, SchoolId = 1, Name = "베트맨" },
                new Student { Id = 2, SchoolId = 1, Name = "슈퍼맨" },
                new Student { Id = 3, SchoolId = 1, Name = "아이언맨" },
                new Student { Id = 4, SchoolId = 2, Name = "이연준" },
                new Student { Id = 5, SchoolId = 2, Name = "윤석열" },
                new Student { Id = 6, SchoolId = 3, Name = "홍길동" },
                new Student { Id = 7, SchoolId = 3, Name = "이순신" },
                new Student { Id = 8, SchoolId = 3, Name = "이연준" },
                new Student { Id = 9, SchoolId = 4, Name = "차범근" },
                new Student { Id = 10, SchoolId = 4, Name = "차두리" },
                new Student { Id = 11, SchoolId = 4, Name = "손흥민" });
        }
    }
}
