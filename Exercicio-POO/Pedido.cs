using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Pedido
    {
        public int Numero;
        public string Produto;
        public int Quantidade;
        public double PrecoUnitario;

        public double CalcularTotal()
        {
            return Quantidade * PrecoUnitario;
        }
    }
}

