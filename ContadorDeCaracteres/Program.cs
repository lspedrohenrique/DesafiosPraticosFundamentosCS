namespace ContadorDeCaracteres;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o texto para contar os caracteres:");
        string? texto = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(texto))
        {
            Console.WriteLine("Texto vazio ou apenas com espaços, tente informar o texto novamente:");
            texto = Console.ReadLine();
        }

        Console.WriteLine("Deseja contabilizar o caractere de espaço? (S - Sim | N - Não)");
        ConsoleKey opcaoUsuario = Console.ReadKey(true).Key;

        while (opcaoUsuario != ConsoleKey.S && opcaoUsuario != ConsoleKey.N)
        {
            Console.WriteLine("Opção incorreta, informe novamente se deseja contabilizar o caractere de espaço (S - Sim | N - Não)");
            opcaoUsuario = Console.ReadKey(true).Key;
        }

        switch (opcaoUsuario)
        {
            case ConsoleKey.S:
                {
                    Console.WriteLine($"\nO texto informado tem {texto.Length} caracteres contando os espaços");
                }
                break;

            case ConsoleKey.N:
                {
                    Console.WriteLine($"\nO texto informado tem {texto.Replace(" ", "").Length} caracteres sem contar os espaços");
                }
                break;
        }
    }
}
