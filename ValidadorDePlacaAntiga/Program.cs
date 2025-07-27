namespace ValidadorDePlacaAntiga;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a placa que deseja validar no formato antigo (AAA-0000)");
        string? placa = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(placa))
        {
            Console.WriteLine("Placa não informada, tente novamente:");
            placa = Console.ReadLine();
        }

        placa = placa.Replace("-", "").Trim().ToUpper();

        if (ValidaPlacaAntiga(placa))
        {
            Console.WriteLine($"A placa {placa} é válida no formato antigo");
        }
        else
        {
            Console.WriteLine($"A placa {placa} é invalida no formato antigo");
        }
    }

    static bool ValidaPlacaAntiga(string placa)
    {
        if (placa.Length != 7)
        {
            return false;
        }

        string parteAlfanumerica = placa.Substring(0, 3);
        string parteNumerica = placa.Substring(3);

        foreach(char caractere in parteAlfanumerica)
        {
            if(!char.IsLetter(caractere))
            {
                return false;
            }
        }

        foreach (char caractere in parteNumerica)
        {
            if (!char.IsNumber(caractere)){
                return false;
            }
        }

        return true;
    }
}
