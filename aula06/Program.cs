using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public delegate int Imprime(int num);
    
    public static int ImprimeNumero(int numero)
    {
        // Console.WriteLine($"ImprimeNumero: {numero}");
        return numero * 2;
    }

    public static int ExibirQuadrado(int numero)
    {
        // Console.WriteLine($"ExibirQuadrado: {numero}");
        return numero * numero;
    }

    public static int Prox(int numero)
    {
        // Console.WriteLine($"Prox: {numero}");
        return numero * numero * numero;
    }

    public static void Main()
    {
        Imprime delegas = ImprimeNumero;
        // delegas(10);

        delegas += ExibirQuadrado;
        // delegas(10);

        delegas += delegate(int numero)
        {
            // Console.WriteLine(numero);
            return numero * 8;
        };

        List<int> numeros = new();
        numeros.Add(delegas(5));

        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }
    }
}