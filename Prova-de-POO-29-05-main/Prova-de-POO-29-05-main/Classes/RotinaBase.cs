using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
    public abstract class RotinaBase : IRotina
    {
        protected string Nome { get; set; }

        public DateTime DataCriacao { get; private set; }

        protected RotinaBase(string nome)
        {
            Nome = nome;
            DataCriacao = DateTime.Now;
        }

        public virtual void ExibirCabecalho()
        {
            Console.WriteLine("\n========================");
            Console.WriteLine($"ROTINA: {Nome}");
            Console.WriteLine("========================");
        }

        public abstract void Executar();

        public virtual string ObterDescricao()
        {
            return Nome;
        }
    }
}