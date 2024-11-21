using EnergiaRuralApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnergiaRuralApi.Data
{
    public class EnergiaRuralContext : DbContext
    {
        public EnergiaRuralContext(DbContextOptions<EnergiaRuralContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Simulacao> Simulacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Simulacoes)
                .WithOne(s => s.Usuario)
                .HasForeignKey(s => s.UsuarioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
