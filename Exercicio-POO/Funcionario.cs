using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public void ExibirDados()
        {
            Console.WriteLine(Nome);
            Console.WriteLine("Salário: R$ " + Salario);
        }
    }
}

