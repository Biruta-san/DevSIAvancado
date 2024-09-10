namespace aula09;

/// <summary>
/// Classe Compra
/// </summary>
public class Compra
{
    /// <summary>
    /// Construtor da classe Compra
    /// </summary>
    /// <param name="cliente">Entiade de Cliente</param>
    /// <param name="produto">Lista de Produtos</param>
    public Compra(Cliente cliente)
    {
        Cliente = cliente;
        Produtos = new List<Produto>();
    }

    /// <summary>
    /// Entidade de Cliente
    /// </summary>
    public Cliente Cliente { get; set; }

    /// <summary>
    /// Lista de Produtos
    /// </summary>
    public List<Produto> Produtos { get; set; }

    /// <summary>
    /// Total da Compra
    /// </summary>
    public decimal Total => Produtos.Sum(x => x.Preco);

    /// <summary>
    /// Realiza a adição de um produto na lista de produtos
    /// </summary>
    /// <param name="produto">Produto a ser adicionado</param>
    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    /// <summary>
    /// Realiza a adição de um produto na lista de produtos
    /// </summary>
    /// <param name="produtos">Lista de Produtos a serem adicionados</param>
    public void AdicionarProduto(List<Produto> produtos)
    {
        Produtos.AddRange(produtos);
    }

    public override string ToString()
    {
        string produtos = string.Join(", ", Produtos.Select(x => x.Nome));
        return $"Cliente: {Cliente}, Produtos: {produtos}\n Total: {Total:C}";
    }
}