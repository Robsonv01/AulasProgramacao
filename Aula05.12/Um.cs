using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05._12
{
    public class Um
    {

        public void ExibirMensagem()
        {
            Console.WriteLine("Bom dia");
        }



        public void Saudacao(string nome)
        {
            Console.WriteLine($"Saudações {nome}!");
        }



        public int GerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }
        public double Media(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }
//7
 public string ClassificarIdade(int idade)
        {
            if (idade < 12)
                return "criança";
            else if (idade < 18)
                return "adolescente";
            else if (idade < 60)
                return "adulto";
            else
                return "idoso";
    }
    //8
    public int MaiorNumero(int[] numeros)
{
    int maior = numeros[0];

    for (int i = 1; i < numeros.Length; i++)
    {
        if (numeros[i] > maior)
        {
            maior = numeros[i];
        }
    }

    return maior;
}
//9
public void Dobrar(ref int numero)
{
    numero = numero * 2;
}
//10
public void Menu()
{
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Sair");
}
}}