namespace MatematicaBasicaEntreDoisValores;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            double numeroA;
            Console.WriteLine("Informe o primeiro número:\n");

            while(!double.TryParse(Console.ReadLine(), out numeroA))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido:");
            }

            double numeroB;
            Console.WriteLine("Agora informe o segundo número:\n");

            while (!double.TryParse(Console.ReadLine(), out numeroB))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido:");
            }

            Console.WriteLine("Informe a operação (A - Soma | B - Subtração | C - Multiplicação | D - Divisão | E - Média)\n");
            ConsoleKey operacao = Console.ReadKey(true).Key;

            switch (operacao)
            {
                case ConsoleKey.A:
                    {
                        Console.WriteLine($"Resultado da Soma: {OperacoesMatematicas.Soma(numeroA, numeroB)}");
                    }
                    break;

                case ConsoleKey.B:
                    {
                        Console.WriteLine($"Resultado da Subtração: {OperacoesMatematicas.Subtrair(numeroA, numeroB)}");
                    }
                    break;

                case ConsoleKey.C:
                    {
                        Console.WriteLine($"Resultado da Multiplicação: {OperacoesMatematicas.Multiplicar(numeroA, numeroB)}");
                    }
                    break;

                case ConsoleKey.D:
                    {
                        if(numeroB == 0)
                        {
                            Console.WriteLine("Não é possível dividir algo por zero.");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado da Divisão: {OperacoesMatematicas.Dividir(numeroA, numeroB)}");
                        }
                    }
                    break;

                case ConsoleKey.E:
                    {
                        Console.WriteLine($"Resultado da Média: {OperacoesMatematicas.Media(numeroA, numeroB)}");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Operação incorreta.");
                    } break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar ou \"S\" para sair");
            ConsoleKey opcaoUsuario = Console.ReadKey(true).Key;

            if(opcaoUsuario == ConsoleKey.S)
            {
                Console.WriteLine("Fim de execução...");
                break;
            }

            Console.Clear();

        } while (true);
    }
}
