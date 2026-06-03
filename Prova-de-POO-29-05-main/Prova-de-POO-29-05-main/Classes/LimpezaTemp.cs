using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
    public class LimpezaTemp : RotinaBase
    {
        private readonly GerenciadorLogs logs;

        public LimpezaTemp(GerenciadorLogs logs)
            : base("Limpeza de Temporários")
        {
            this.logs = logs;
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Random r = new();
            int removidos = r.Next(20, 200);

            Console.WriteLine($"Arquivos removidos: {removidos}");

            logs.AdicionarLog(
                $"Limpeza executada. Arquivos removidos: {removidos}"
            );
        }
    }
}