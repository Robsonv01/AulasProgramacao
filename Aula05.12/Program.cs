using Aula05._12;

/* Calculadora calculadora = new Calculadora();

Console.WriteLine(calculadora.Somar(5, 3)); */
//1
Um um = new Um();

um.ExibirMensagem();
//2
um.Saudacao("Robson");
//3
int numeroAleatorio = um.GerarNumeroAleatorio();
Console.WriteLine("Número aleatório gerado: " + numeroAleatorio);

//4
Console.WriteLine("Resultado da soma: " + um.Somar(1, 2));
//5
 Console.WriteLine("É par? " + um.EhPar(10));

//6 
        Console.WriteLine("Média: " + um.Media(7.5, 8.0, 9.0));

//7
        Console.WriteLine("Classificação: " + um.ClassificarIdade(25));
// 8 
int[] valores = { 5, 10, 3, 40, 2 };
Console.WriteLine("Maior número: " + um.MaiorNumero(valores));

// 9
int n = 10;
um.Dobrar(ref n);
Console.WriteLine("Valor dobrado: " + n);

// 10
um.Menu();