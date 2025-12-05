using System;

class Program
{
    static void Main()
    {
        //1        
        Console.WriteLine("1 - Pessoa");
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Homi";
        pessoa.Idade = 100;
        pessoa.ExibirDados();
        //2
        Console.WriteLine("2 - Conta Bancária");
        ContaBancaria conta = new ContaBancaria();
        conta.NumeroConta = "123";
        conta.Depositar(100);
        conta.Sacar(20);
        conta.ExibirSaldo();

        //3 
        Calculadora calc = new Calculadora();

        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Soma: {calc.Somar(a, b)}");
        Console.WriteLine($"Subtração: {calc.Subtrair(a, b)}");
        Console.WriteLine($"Multiplicação: {calc.Multiplicar(a, b)}");
        Console.WriteLine($"Divisão: {calc.Dividir(a, b)}");

        //4
        Console.WriteLine("4 -Produto");
        Produto p = new Produto("Mouse", 50.0, 2);
        Console.WriteLine("Total: " + p.CalcularTotal());
        //5
        Console.WriteLine("5 - Aluno ");
        Aluno aluno = new Aluno();
        aluno.Nome = "Zé";
        aluno.Nota1 = 6.5;
        aluno.Nota2 = 7.0;

        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");
    }
}
