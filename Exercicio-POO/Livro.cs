using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public bool Disponivel;

        public void Emprestar()
        {
            Disponivel = false;
        }

        public void Devolver()
        {
            Disponivel = true;
        }
    }
}

