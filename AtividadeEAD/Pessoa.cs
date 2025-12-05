public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
}
