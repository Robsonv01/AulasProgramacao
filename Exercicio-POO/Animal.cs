using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Animal
    {
        public string Nome;
        public string Especie;

        public void EmitirSom()
        {
            if (Especie == "Cachorro")
            {
                Console.WriteLine("Au Au");
            }
            else if (Especie == "Gato")
            {
                Console.WriteLine("Miau");
            }
        }
    }
}

