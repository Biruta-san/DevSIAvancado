namespace aula09;

/// <summary>
/// Classe Produto
/// </summary>
public class Produto
{
    /// <summary>
    /// Construtor da classe Produto
    /// </summary>
    /// <param name="id">Identificador do Produto</param>
    /// <param name="nome">Nome do Produto</param>
    /// <param name="preco">Preço do Produto</param>
    public Produto(int id, string nome, decimal preco)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
    }

    /// <summary>
    /// Identificador do produto
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome do produto
    /// </summary>/
    public string Nome { get; set; }

    /// <summary>
    /// Preço do produto
    /// </summary>
    public decimal Preco { get; set; }

    /// <summary>
    /// Método ToString sobrescrito
    /// </summary>
    /// <returns>Retorna uma string com os dados do produto</returns>
    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Preço: {Preco:C}";
    }
}