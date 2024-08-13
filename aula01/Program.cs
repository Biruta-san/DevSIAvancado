using aula01.classes;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        var pess = new Pessoa(15, "shaolin matador de porco");

        string? nome = Console.ReadLine();
        bool idade = int.TryParse(Console.ReadLine(), out int valor);

        var pess1 = new Pessoa(valor, nome);

        Console.WriteLine(pess);
    }
}
