namespace DataFormatada;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o formato que deseja ver a data e hora:");
        Console.WriteLine("A - Completo | B - Cabeçalho | C - Simples | D - Apenas horas\n");
        ConsoleKey opcaoUsuario = Console.ReadKey(true).Key;

        switch (opcaoUsuario)
        {
            case ConsoleKey.A:
                {
                    Console.WriteLine(DateTime.Now.ToString("F"));
                }
                break;

            case ConsoleKey.B:
                {
                    Console.WriteLine(DateTime.Now.ToString("D"));
                }
                break;

            case ConsoleKey.C:
                {
                    Console.WriteLine(DateTime.Now.ToString("d"));
                }
                break;

            case ConsoleKey.D:
                {
                    Console.WriteLine(DateTime.Now.ToString("T"));
                }
                break;

            default:
                {
                    Console.WriteLine("Opção não encontrada");
                } break;
        }
    }
}
