/* // See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe o nome da 1º pessoa");
string nome = Console.ReadLine();

Console.WriteLine("Informe a idade da 1º pessoa");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o nome da 2º pessoa");
string nome2 = Console.ReadLine();

Console.WriteLine("Informe a idade da 2º pessoa");
int idade2 = int.Parse(Console.ReadLine());

if (idade > idade2)
{
    Console.WriteLine($"a PESSOA {nome} e a mas velha com a idade {idade}");
}
else if (idade == idade2)
{
    Console.WriteLine("Ambas tem a mesa idade");
}
else
{
    Console.WriteLine($"A pessoa {nome2} e a mas velha com a idade {idade2} ");
}

string usuario, senha;
int tentativas;

for (tentativas = 1; tentativas <= 3; tentativas++)
{
    Console.WriteLine("Entre com o usuário:");
    usuario = Console.ReadLine();

    Console.WriteLine("Entre com a senha:");
    senha = Console.ReadLine();

    if (usuario == "admin" && senha == "1234")
        break;

    Console.WriteLine("Usuário ou senha inválidos.");
}

if (tentativas <= 3)
    Console.WriteLine("Acesso liberado");
else
    Console.WriteLine("Acesso bloqueado");
 */
using System.Collections;
// atividade
/* Console.WriteLine("Entre com o primeiro numero");
 int num = int.Parse(Console.ReadLine());
 Console.WriteLine("Entre com o segundo numero");
 int num2 = int.Parse(Console.ReadLine());
 
 Console.WriteLine("1. soma\n2. subtração\n3. multiplicação \n4. Divisão ");
 int opc = int.Parse(Console.ReadLine());
 switch(opc)
 {
    case 1:
        Console.WriteLine(num + num2);
        break;

    case 2:
        Console.WriteLine(num - num2);
        break;

    case 3:
        Console.WriteLine(num * num2);
        break;

    case 4:
        Console.WriteLine(num / num2);
        break;

    default:
        Console.WriteLine("Opção inválida");
        break;
}

Console.WriteLine("Coloque um numero :");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine($"O dobro é {num3 * 2} e o triplo é {num3 * 3}");

Console.WriteLine("Qual o seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Seja bem vindo  {nome}");

Console.WriteLine("Qual o sua idade");
int idade3 = int.Parse(Console.ReadLine());
Console.WriteLine($"idade terá daqui a 10 anos. {idade3 + 10}"); */


//  2. Estruturas Condicionais (if / else)

Console.WriteLine("Coloque um numero :");
int numero1 = int.Parse(Console.ReadLine());

if (numero1 % 2 == 0)
{
    Console.WriteLine($"{numero1} é par");
}
else
{
        Console.WriteLine($"{numero1} é impar");

}

Console.WriteLine("Coloque o primeiro numero :");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Coloque o segundo numero :");
int numero3 = int.Parse(Console.ReadLine());

// 2 - b
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
    Console.WriteLine("O maior é " + a);
else if (b > a)
    Console.WriteLine("O maior é " + b);
else
    Console.WriteLine("São iguais");

    //2 c
    int nota = int.Parse(Console.ReadLine());

if (nota >= 7)
    Console.WriteLine("Aprovado");
else if (nota >= 5)
    Console.WriteLine("Recuperação");
else
    Console.WriteLine("Reprovado");

    // 2 d
    int idade4 = int.Parse(Console.ReadLine());

if (idade4 < 18)
    Console.WriteLine("Menor de idade");
else if (idade4 < 60)
    Console.WriteLine("Adulto");
else
    Console.WriteLine("Idoso");

    // 2 e
    int n = int.Parse(Console.ReadLine());

if (n > 0)
    Console.WriteLine("Positivo");
else if (n < 0)
    Console.WriteLine("Negativo");
else
    Console.WriteLine("Zero");

// 3 
for (int i = 1; i <= 10; i++)
    Console.WriteLine(i);
    //b
    for (int i = 2; i <= 50; i += 2)
    Console.WriteLine(i);
    //c
    int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
    Console.WriteLine($"{num} x {i} = {num * i}");

// d
int soma = 0;
int valor;

do
{
    valor = int.Parse(Console.ReadLine());
    soma += valor;
} while (valor != 0);

Console.WriteLine("Soma = " + soma);

//e
int positivos = 0;

for (int i = 0; i < 5; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x > 0)
        positivos++;
}

Console.WriteLine("Positivos: " + positivos);
// 4 a
int opc = int.Parse(Console.ReadLine());
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1: Console.WriteLine(n1 + n2); break;
    case 2: Console.WriteLine(n1 - n2); break;
    case 3: Console.WriteLine(n1 * n2); break;
    case 4: Console.WriteLine(n1 / n2); break;
    default: Console.WriteLine("Opção inválida"); break;
}
// b
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1: Console.WriteLine("Domingo"); break;
    case 2: Console.WriteLine("Segunda"); break;
    case 3: Console.WriteLine("Terça"); break;
    case 4: Console.WriteLine("Quarta"); break;
    case 5: Console.WriteLine("Quinta"); break;
    case 6: Console.WriteLine("Sexta"); break;
    case 7: Console.WriteLine("Sábado"); break;
    default: Console.WriteLine("Inválido"); break;
}
// c
int cod = int.Parse(Console.ReadLine());

switch (cod)
{
    case 1: Console.WriteLine("Alimento"); break;
    case 2: Console.WriteLine("Bebida"); break;
    case 3: Console.WriteLine("Limpeza"); break;
    default: Console.WriteLine("Categoria inválida"); break;
}
//d
int codp = int.Parse(Console.ReadLine());

switch (codp)
{
    case 1: Console.WriteLine("Alimento"); break;
    case 2: Console.WriteLine("Bebida"); break;
    case 3: Console.WriteLine("Limpeza"); break;
    default: Console.WriteLine("Categoria inválida"); break;
}
// 5
int soma5 = 0;
int maior = int.MinValue;

for (int i = 0; i < 10; i++)
{
    int n5 = int.Parse(Console.ReadLine());
    soma += n2;
    if (n5 > maior)
        maior = n5;
}

Console.WriteLine("Soma: " + soma5);
Console.WriteLine("Média: " + soma5 / 10);
Console.WriteLine("Maior: " + maior);

// b
int soma2 = 0, cont = 0, idade;

while (true)
{
    idade = int.Parse(Console.ReadLine());
    if (idade < 0) break;

    soma2 += idade;
    cont++;
}

Console.WriteLine("Média: " + (soma2 / cont));

// c
int par = 0, impar = 0;
int n22;

while (true)
{
    n22 = int.Parse(Console.ReadLine());
    if (n22 == 0) break;  // Para o loop se digitar 0

    if (n22 % 2 == 0)
        par++;
    else
        impar++;
}

Console.WriteLine("Pares: " + par);
Console.WriteLine("Ímpares: " + impar);

// 6 desafios 

int n6 = int.Parse(Console.ReadLine());
bool primo = true;

for (int i = 2; i < n6; i++)
{
    if (n6 % i == 0)
        primo = false;
}

Console.WriteLine(primo ? "Primo" : "Não é primo");
// b
int n7 = int.Parse(Console.ReadLine());
int fat = 1;

for (int i = 1; i <= n7; i++)
    fat *= i;

Console.WriteLine(fat);

// 6 c
int tentativas = 0;
string senha;

while (tentativas < 3)
{
    senha = Console.ReadLine();
    if (senha == "123")
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
    tentativas++;
}
//d 
int saldo = 1000;

while (saldo > 0)
{
    int saque = int.Parse(Console.ReadLine());
    if (saque <= saldo)
        saldo -= saque;
    else
        Console.WriteLine("Saldo insuficiente");
}
