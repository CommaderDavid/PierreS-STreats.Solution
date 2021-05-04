
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreS_STreat.Models
{
    public class PierreS_STreatContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavor> Flavors { get; set; }
        public virtual DbSet<Treat> Treats { get; set; }
        public virtual DbSet<FlavorTreat> FlavorTreat { get; set; }

        public PierreS_STreatContext(DbContextOptions options) : base(options) { }
    }
}