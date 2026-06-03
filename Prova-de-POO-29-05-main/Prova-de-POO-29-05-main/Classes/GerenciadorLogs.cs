using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
 public class GerenciadorLogs
    {
        private List<string> logs = new();

        public void AdicionarLog(string mensagem)
        {
            logs.Add(
                $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - {mensagem}"
            );
        }

        public void MostrarLogs()
        {
            if (logs.Count == 0)
            {
                Console.WriteLine("Nenhum log registrado.");
                return;
            }

            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
    }
}