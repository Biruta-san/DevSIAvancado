
6555;

public class Venda
{
    public Venda()
    {
    }

    public Venda(Cliente cliente)
    {
        Cliente = cliente;
        Livros = new List<Livro>();
    }

    public int Id { get; set; }

    public Cliente Cliente { get; set; }

    public List<Livro> Livros { get; set; }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }
    
    public void AdicionarLivro(List<Livro> livros)
    {
        Livros.AddRange(livros);
    }

    public void RemoverLivro(Livro livro)
    {
        Livros.Remove(livro);
    }

    public void RemoverLivro(List<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Livros.Remove(livro);
        }
    }

    public override string ToString()
    {
        return $"Id: {Id}, Cliente: {Cliente}, Livros: {string.Join(", ", Livros)}";
    }
}