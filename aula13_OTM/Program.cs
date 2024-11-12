using Microsoft.EntityFrameworkCore;

namespace aula13_OTM;
public class Program
{
    public static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var categoria = new Categoria(1, "Alimentos", null);
            db.Categorias.Add(categoria);

            var produto = new Produto(0, "Arroz", 1);
            db.Produtos.Add(produto);

            db.SaveChanges();

            var produtos = db.Produtos.Include(p => p.Categoria).ToList();
            foreach (var p in produtos)
            {
                Console.WriteLine($"Produto: {p.Nome} - Categoria: {p.Categoria.Nome}");
            }
        }
    }
}