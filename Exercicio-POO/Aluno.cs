using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;

        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public void VerificarAprovacao()
        {
            if (CalcularMedia() >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}