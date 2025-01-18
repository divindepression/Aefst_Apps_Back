using Aefst.Apps.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Aefst.Apps.Infrastructure.Context
{
    public class AefstAppsDbContext : DbContext
    {
        public AefstAppsDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Tuteur> Tuteurs { get; set; }
        public DbSet<Adhesion> Adhesions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
