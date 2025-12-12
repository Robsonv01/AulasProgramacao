/* int numero;
        int soma = 0;

        do
        {
            Console.Write("Digite um número (0 para encerrar): ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;

        } while (numero != 0);

        Console.WriteLine("A soma dos números digitados é: " + soma); */

       //2 string senha = "";

      /*   while (senha != "1234")
        {
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
        }

        Console.WriteLine("Senha correta. Acesso liberado!"); */
    
  //3  int i = 50;
/* 
        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        } */

//4 bool repetir = true;

       /*  while (repetir)
        {
            Console.Write("Quantos alunos existem na turma? ");
            int quantidade = int.Parse(Console.ReadLine());

            double[] notas = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                double nota;
                do
                {
                    Console.Write($"Digite a nota do aluno {i + 1} (0 a 10): ");
                    nota = double.Parse(Console.ReadLine());
                }
                while (nota < 0 || nota > 10); // OPCIONAL: validação

                notas[i] = nota;
            }

            Console.WriteLine("\nNotas digitadas:");
            foreach (double n in notas)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            double maior = notas[0];
            double menor = notas[0];
            double soma = 0;

            foreach (double n in notas)
            {
                if (n > maior) maior = n;
                if (n < menor) menor = n;
                soma += n;
            }

            double media = soma / quantidade;

            int acimaMedia = 0;
            foreach (double n in notas)
            {
                if (n > media)
                    acimaMedia++;
            }

            double[] notasOrdenadas = (double[])notas.Clone();
            Array.Sort(notasOrdenadas);

            Console.WriteLine("\n===== RESULTADOS =====");
            Console.WriteLine($"Maior nota: {maior}");
            Console.WriteLine($"Menor nota: {menor}");
            Console.WriteLine($"Média da turma: {media:F2}");
            Console.WriteLine($"Alunos acima da média: {acimaMedia}");

            Console.WriteLine("Notas ordenadas (menor → maior):");
            foreach (double n in notasOrdenadas)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nDeseja cadastrar outra turma? (S/N)");
            string opc = Console.ReadLine().ToUpper();

            if (opc != "S")
                repetir = false;

            Console.WriteLine();
        }

        Console.WriteLine("Programa encerrado!");
     */
using System;
using System.Collections.Generic;
using atividade.ead;

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>()
        {
            new Produto(){ Id=1, Nome="Mouse", Preco=50, Estoque=10 },
            new Produto(){ Id=2, Nome="Teclado", Preco=100, Estoque=5 },
            new Produto(){ Id=3, Nome="Fone", Preco=80, Estoque=8 }
        };

        int opcao = 0;

        while (opcao != 6)
        {
            Console.WriteLine("\n1 - Listar produtos");
            Console.WriteLine("2 - Adicionar produto");
            Console.WriteLine("3 - Buscar por nome");
            Console.WriteLine("4 - Aumentar estoque");
            Console.WriteLine("5 - Diminuir estoque");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    foreach (var p in produtos)
                        p.ExibirInformacoes();
                    break;

                case 2:
                    Produto novo = new Produto();
                    Console.Write("ID: ");
                    novo.Id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    novo.Nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    novo.Preco = double.Parse(Console.ReadLine());
                    Console.Write("Estoque: ");
                    novo.Estoque = int.Parse(Console.ReadLine());
                    produtos.Add(novo);
                    break;

                case 3:
                    Console.Write("Nome: ");
                    string busca = Console.ReadLine().ToLower();
                    foreach (var p in produtos)
                        if (p.Nome.ToLower().Contains(busca))
                            p.ExibirInformacoes();
                    break;

                case 4:
                    Console.Write("ID: ");
                    int idAdd = int.Parse(Console.ReadLine());
                    Console.Write("Qtd: ");
                    int qtdAdd = int.Parse(Console.ReadLine());
                    var prodAdd = produtos.Find(x => x.Id == idAdd);
                    if (prodAdd != null) prodAdd.AdicionarEstoque(qtdAdd);
                    break;

                case 5:
                    Console.Write("ID: ");
                    int idRem = int.Parse(Console.ReadLine());
                    Console.Write("Qtd: ");
                    int qtdRem = int.Parse(Console.ReadLine());
                    var prodRem = produtos.Find(x => x.Id == idRem);
                    if (prodRem != null) prodRem.RemoverEstoque(qtdRem);
                    break;
            }
        }
    }
}