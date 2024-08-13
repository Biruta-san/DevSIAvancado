namespace aula01.classes;

/// <summary>
/// Classe de Pessoa
/// </summary>
public class Pessoa
{
    /// <summary>
    /// Construtor completo
    /// </summary>
    /// <param name="idade">Idade da pessoa</param>
    /// <param name="nome">Nome da pessoa</param>
    public Pessoa(int idade, string? nome)
    {
        Idade = idade;
        Nome = nome;
    }

    /// <summary>
    /// Idade da pessoa
    /// </summary>
    public int Idade { get; set; }

    /// <summary>
    /// Nome da pessoa
    /// </summary>
    public string? Nome { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}