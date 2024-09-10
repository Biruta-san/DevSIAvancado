namespace aula09;

/// <summary>
/// Classe Cliente
/// </summary>
public class Cliente
{
    /// <summary>
    /// Construtor da classe Cliente
    /// </summary>
    /// <param name="id">Identificador do Cliente</param>
    /// <param name="nome">Nome do Cliente</param>
    public Cliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    /// <summary>
    /// Identificador do cliente
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nome do cliente
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Método ToString sobrescrito
    /// </summary>
    /// <returns>Retorna string com os dados do cliente</returns>
    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}";
    }
}