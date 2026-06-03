using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Filme
    {
        public string Titulo;
        public string Genero;
        public int Duracao;

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Gênero: " + Genero);
            Console.WriteLine("Duração: " + Duracao + " min");
        }
        public void IniciarFilme()
        {
            Console.WriteLine("Filme Iniciado");
        }
    }
}