using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_POO
{
    public class Retangulo
    {
        public int Base;
        public int altura;
        public double CalcularArea()
        {
            return Base * altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Base + altura);
        }
    }
}