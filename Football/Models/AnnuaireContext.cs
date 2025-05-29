using Microsoft.EntityFrameworkCore;

namespace Football.Models
{
        public class AnnuaireContext : DbContext
        {
            public DbSet<Maillot> Maillots { get; set; }

            public AnnuaireContext(DbContextOptions options) : base(options)
            {

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //base.OnConfiguring(optionsBuilder);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Maillot>().Property(m => m.Description).IsRequired();
                modelBuilder.Entity<Maillot>().Property(m => m.Couleur).IsRequired();
                modelBuilder.Entity<Maillot>().Property(m => m.Picture).IsRequired();
                modelBuilder.Entity<Maillot>().Property(m => m.Taille).IsRequired();
                modelBuilder.Entity<Maillot>().Property(m => m.Prix).IsRequired();
                modelBuilder.Entity<Maillot>().Property(m => m.Pays).IsRequired();
            }
        }
}
