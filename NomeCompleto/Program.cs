namespace NomeCompleto;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome:");
        string? nome = Console.ReadLine();

        Console.WriteLine("\nAgora informe seu sobrenome:");
        string? sobrenome = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(sobrenome))
        {
            Console.WriteLine($"\nNome completo: {nome.Trim()} {sobrenome.Trim()}");
        }
        else
        {
            Console.WriteLine("\nNome ou Sobrenome não informado");
        }
    }
}
