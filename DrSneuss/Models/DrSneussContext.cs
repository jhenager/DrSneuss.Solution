using Microsoft.EntityFrameworkCore;

namespace DrSneuss.Models
{
  public class DrSneussContext : DbContext
  {
    public virtual DbSet<Machine> Machines { get; set; }
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<MachineEngineer> MachineEngineer { get; set; }
    public DrSneussContext(DbContextOptions options) : base(options) { }
  }
}