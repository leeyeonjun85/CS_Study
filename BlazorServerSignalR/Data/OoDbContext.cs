using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSignalR.Data
{
    public class OoDbContext : DbContext
    {

        // DbSet
        public DbSet<School> schools { get; set; }
        public DbSet<Student> students { get; set; }

        public OoDbContext(DbContextOptions<OoDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                new School { id = 1, name = "평택초" },
                new School { id = 2, name = "아산초" });

            modelBuilder.Entity<Student>().HasData(
                new Student { id = 1, name = "베트맨", schoolId = 1 },
                new Student { id = 2, name = "슈퍼맨", schoolId = 1 },
                new Student { id = 3, name = "이연준", schoolId = 2 });
        }

    }
}