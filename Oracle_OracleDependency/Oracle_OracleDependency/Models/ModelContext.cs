using Microsoft.EntityFrameworkCore;

namespace Oracle_OracleDependency.Models;

public partial class ModelContext : DbContext
{
    public DbSet<School>? Schools { get; set; }
    public DbSet<Room>? Rooms { get; set; }
    public DbSet<Student>? Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseOracle("User Id=testuser1;Password=0330;Data Source=localhost:1521/XEPDB1;");
}
