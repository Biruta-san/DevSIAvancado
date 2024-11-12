namespace aula11EF.Models;
public class Livro
{
    public Livro()
    {
    }

    public Livro(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public decimal Preco { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Preço: {Preco:C}";
    }
}