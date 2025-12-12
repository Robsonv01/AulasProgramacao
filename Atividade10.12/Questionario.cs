using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade10._12
{
    public class Questionario
    {
        public string Categoria { get; set; }
        public List<string> Perguntas { get; set; }

        public Questionario(string categoria)
        {
            this.Categoria = categoria;
            this.Perguntas = new List<string>();
            Console.WriteLine("Entrou no construtor!");
        }
    }
}