using Microsoft.EntityFrameworkCore;

namespace aula13_OTM;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=relacionamento.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>()
            .HasOne(a => a.Categoria)
            .WithMany(b => b.Produtos)
            .HasForeignKey(a => a.CategoriaId);
    }
}