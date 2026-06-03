using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
public class DiagnosticoSistema : RotinaBase
    {
        public DiagnosticoSistema()
            : base("Diagnóstico do Sistema")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Console.WriteLine($"Máquina: {Environment.MachineName}");
            Console.WriteLine($"Usuário: {Environment.UserName}");
            Console.WriteLine($"Sistema: {Environment.OSVersion}");
            Console.WriteLine($"Data/Hora: {DateTime.Now}");
        }
    }
}