using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int VelocidadeAtual;

        public void Acelerar()
        {
            VelocidadeAtual += 10;
        }
        public void Frear()
        {
            VelocidadeAtual -= 10;
        }
        public void ExibirVelocidade()
        {
            Console.WriteLine("Velocidade: " + VelocidadeAtual + " km/h");

        }
    }

}