

using Aula08._12;
/* Funcoes f = new Funcoes();
f.BoaTarde("Zé");
 */
Produto p = new Produto();
List<Produto> lista = new List<Produto>();


int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("1-  Cadastrar produto");
    Console.WriteLine("2 - Listar produtos");
    Console.WriteLine("3 - Sair");
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Cadastrar();
    }
    else if (opcao == 2)
    {
        Listar();
    }
}
void Cadastrar()
    {
        Produto p = new Produto();

        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        p.Preco = int.Parse(Console.ReadLine());

        lista.Add(p);

        Console.WriteLine("Produto cadastrado!");
    }

 void Listar()
    {
        Console.WriteLine("\nProdutos cadastrados:");

        foreach (Produto p in lista)
        {
            Console.WriteLine($"{p.Nome} - R${p.Preco}");
        }
    }

