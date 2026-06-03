using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
 public class BackupRotina : RotinaBase
    {
        public BackupRotina()
            : base("Backup Automático")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Console.Write("Origem: ");
            string origem = Console.ReadLine();

            Console.Write("Destino: ");
            string destino = Console.ReadLine();

            Console.WriteLine(
                $"Backup simulado de {origem} para {destino}"
            );
        }
    }
}