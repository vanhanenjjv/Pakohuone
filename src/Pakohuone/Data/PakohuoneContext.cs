using Microsoft.EntityFrameworkCore;
using Pakohuone.Entities;

namespace Pakohuone.Data
{
    public class PakohuoneContext : DbContext
    {
        public PakohuoneContext(DbContextOptions<PakohuoneContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<World> Worlds { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Level> Levels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<World>()
                .HasIndex(w => w.Name)
                .IsUnique();
            modelBuilder.Entity<World>()
                .HasIndex(w => w.Directory)
                .IsUnique();

            modelBuilder.Entity<Room>()
              .HasIndex(l => l.Name);

            modelBuilder.Entity<Level>()
                .HasIndex(l => l.Name)
                .IsUnique();
            modelBuilder.Entity<Level>()
                .HasIndex(l => l.Directory)
                .IsUnique();
        }
    }
}
