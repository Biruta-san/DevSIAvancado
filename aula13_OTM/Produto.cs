namespace aula13_OTM;

public class Produto 
{
    public Produto()
    {
    }

    public Produto(int id, string nome, int categoriaId)
    {
        Id = id;
        Nome = nome;
        CategoriaId = categoriaId;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public int CategoriaId { get; set; }

    public virtual Categoria Categoria { get; set; }
}