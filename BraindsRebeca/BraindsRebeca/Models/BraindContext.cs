using Microsoft.EntityFrameworkCore;

namespace BraindsRebeca.Models
{
    public class BraindContext : DbContext
    {
        public BraindContext(DbContextOptions<BraindContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Braind> Brainds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Braind>()
                .HasData(
                    new Braind
                    {
                        Id = 1,
                        Nome = "Kaio",
                        Descricao = "Boxeadora",                   
                        Telefone = "(11) 99208-3484"
        }
    );

        }
    }
}
