public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Valor indisponível!");
            return;
        }

        Saldo -= valor;
        Console.WriteLine("Valor sacado!");
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo: R$ {Saldo}");
    }
}