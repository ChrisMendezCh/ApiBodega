using Apibodega.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace Apibodega.Backend.Data
{
    public class Datacontext : DbContext

    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasIndex(ct => ct.Name).IsUnique();
        }
    }
}