namespace aula11EF.Models;
public class Cliente
{
    public Cliente()
    {
    }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;0
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public int Idade { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}";
    }
}