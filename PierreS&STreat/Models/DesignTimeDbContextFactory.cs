using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierreS_STreat.Models
{
    public class PierreS_STreatContextFactory : IDesignTimeDbContextFactory<PierreS_STreatContext>
    {

        PierreS_STreatContext IDesignTimeDbContextFactory<PierreS_STreatContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<PierreS_STreatContext>();
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new PierreS_STreatContext(builder.Options);
        }
    }
}