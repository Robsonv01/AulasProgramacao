using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
public class MonitorMemoria : RotinaBase
    {
        private double usoMemoria;

        public MonitorMemoria()
            : base("Monitor de Memória")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Random r = new();

            usoMemoria = r.Next(20, 100);

            Console.WriteLine($"Uso de memória: {usoMemoria}%");

            if (usoMemoria > 80)
            {
                Console.WriteLine("ALERTA: uso elevado!");
            }
        }
    }
}