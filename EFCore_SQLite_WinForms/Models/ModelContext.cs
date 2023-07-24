using Microsoft.EntityFrameworkCore;

namespace EFCore_SQLite_WinForms.Models
{
    public class ModelContext : DbContext
    {
        string _connectionString;

        public ModelContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Student> students { get; set; }
        public DbSet<School> schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(_connectionString);
    }
}
