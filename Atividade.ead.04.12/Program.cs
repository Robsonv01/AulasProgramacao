using System;
using atividade.ead;
Produto produto = null;

int escolha = 0;

while (escolha != 4)
{

    Console.WriteLine("1 - Cadastrar produto");
    Console.WriteLine("2 - Exibir produto");
    Console.WriteLine("3 - Exibir valor total em estoque");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    escolha = int.Parse(Console.ReadLine());
  

    switch (escolha)
    {
        case 1:
            produto = new Produto();

            Console.Write("Nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nProduto cadastrado com sucesso!");
            break;

        case 2:
            if (produto == null)
            {
                Console.WriteLine("Nenhum produto cadastrado!");
            }
            else
            {
                Console.WriteLine("DADOS DO PRODUTO ");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: R$ {produto.Preco}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}");
            }
            break;

        case 3:
            if (produto == null)
            {
                Console.WriteLine("Nenhum produto cadastrado!");
            }
            else
            {
                Console.WriteLine("VALOR DO ESTOQUE ");
                Console.WriteLine($"Total: R$ {produto.ValorTotal()}");
            }
            break;

        case 4:
            Console.WriteLine("Saindo do programa...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente!");
            break;
    }

    if (escolha != 4)
    {
        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
        Console.ReadLine();
   
    }
}

