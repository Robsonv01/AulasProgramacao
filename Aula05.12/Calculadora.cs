using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula05._12
{
    public class Calculadora
    {
        public string Somar(double a, double b)
        {
            double Soma = a + b;
            return $"O resultado da soma é {Soma}";
        }
    }
}