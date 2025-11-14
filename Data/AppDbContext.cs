using Microsoft.EntityFrameworkCore;
using SistemaGestaoDeBovinos.Models;

namespace SistemaGestaoDeBovinos.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Pasto> Pastos { get; set; }
        public DbSet<EventoAnimal> EventosAnimais { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Financeiro> Financeiros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gestaobovinos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Lote)
                .WithMany(l => l.Animais)
                .HasForeignKey(a => a.LoteId);

            modelBuilder.Entity<Lote>()
                .HasOne(l => l.PastoAtual)
                .WithOne(p => p.LoteAlocado)
                .HasForeignKey<Lote>(l => l.PastoAtualId);

            modelBuilder.Entity<EventoAnimal>()
                .HasOne(e => e.Animal)
                .WithMany(a => a.Historico)
                .HasForeignKey(e => e.AnimalId);
        }
    }
}