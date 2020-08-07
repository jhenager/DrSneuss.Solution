using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DrSneuss.Models
{
  public class DrSneussContextFactory : IDesignTimeDbContextFactory<DrSneussContext>
  {

    DrSneussContext IDesignTimeDbContextFactory<DrSneussContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<DrSneussContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new DrSneussContext(builder.Options);
    }
  }
}