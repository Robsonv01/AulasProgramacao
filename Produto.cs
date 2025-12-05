using System;
namespace atividade.ead;
public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}