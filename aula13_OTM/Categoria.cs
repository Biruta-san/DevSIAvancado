namespace aula13_OTM;
public class Categoria
{
    public Categoria()
    {
        Produtos = new List<Produto>();
    }

    public Categoria(int id, string nome, ICollection<Produto> produtos)
    {
        Id = id;
        Nome = nome;
        Produtos = produtos ?? new List<Produto>();
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; }
}