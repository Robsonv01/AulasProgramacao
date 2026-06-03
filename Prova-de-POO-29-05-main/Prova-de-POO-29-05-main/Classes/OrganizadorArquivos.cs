using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_de_POO_29_05
{
 public class OrganizadorArquivos : RotinaBase
    {
        public OrganizadorArquivos()
            : base("Organizador de Arquivos")
        {
        }

        public override void Executar()
        {
            ExibirCabecalho();

            Console.WriteLine("Imagens organizadas.");
            Console.WriteLine("Vídeos organizados.");
            Console.WriteLine("Documentos organizados.");
        }
    }
}