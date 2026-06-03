using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Exercicio_POO;

namespace Exercicio_POO
{
    public class Celular
    {
        public string Marca;
        public string Modelo;
        public int Bateria;

        public void Ligar()
        {
            Console.WriteLine("Celular Ligado");
        }

        public void Carregar()
        {
            Bateria = 100;
        }

        public void MostrarStatus()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(Bateria + "%");
        }
    }
}