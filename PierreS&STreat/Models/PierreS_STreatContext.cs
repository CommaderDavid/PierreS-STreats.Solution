
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierreS_STreat.Models
{
    public class PierreS_STreatContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavor> Tags { get; set; }
        public virtual DbSet<Treat> Recipes { get; set; }
        public virtual DbSet<FlavorTreat> RecipeTag { get; set; }

        public PierreS_STreatContext(DbContextOptions options) : base(options) { }
    }
}