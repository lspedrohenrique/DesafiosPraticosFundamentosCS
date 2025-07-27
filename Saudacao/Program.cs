namespace Saudacao;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome:");
        string? nome = Console.ReadLine();

        string saudacao = !string.IsNullOrWhiteSpace(nome)
            ? $"Olá, {nome.Trim()}! Seja muito bem-vindo!"
            : "Nome não informado";

        Console.WriteLine(saudacao);
    }
}
