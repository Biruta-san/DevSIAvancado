using System.Globalization;

namespace aula09;

/// <summary>
/// Classe Program
/// </summary>
public class Program
{
    public static void Main()
    {
        // Configurar a cultura para pt-BR
        CultureInfo culture = new("pt-BR");
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;

        List<Produto> produtos = [new(1, "Produto 1", 10.0m), new(2, "Produto 2", 20.0m), new(3, "Produto 3", 30.0m)];
        Cliente cliente = new(1, "Cliente 1");
        Compra compra = new(cliente);

        compra.AdicionarProduto(produtos);

        Console.WriteLine(compra);
    }
}