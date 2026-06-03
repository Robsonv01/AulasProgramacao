using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Jogo
    {
        public string Nome;
        public string Plataforma;
        public int Pontuacao;

        public void Jogar()
        {
            Console.WriteLine("Iniciando o jogo: " + Nome);
        }
        public void SalvarProgresso()
        {
            Console.WriteLine("Salvando o Progresso");

        }
        public void MostrarPontuacao()
        {
            Console.WriteLine("Pontuação " + Pontuacao);
        }
    }
}