using System;
namespace atividade.ead

{
    class Produto
{
    public int Id;
    public string Nome;
    public double Preco;
    public int Estoque;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"ID: {Id} | Nome: {Nome} | Preço: {Preco} | Estoque: {Estoque}");
    }

    public void AdicionarEstoque(int qtd)
    {
        Estoque += qtd;
    }

    public void RemoverEstoque(int qtd)
    {
        if (qtd <= Estoque)
        {
            Estoque -= qtd;
        }
        else
        {
            Console.WriteLine("Não há estoque suficiente.");
        }
    }
}
}