using System;
using System.Collections.Generic;

namespace Prova_de_POO_29_05
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorLogs logs = new GerenciadorLogs();

            List<IRotina> rotinas = new List<IRotina>()
            {
                new LimpezaTemp(logs),
                new MonitorMemoria(),
                new BackupRotina(),
                new OrganizadorArquivos(),
                new DiagnosticoSistema()
            };

            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1 - Executar Limpeza");
                Console.WriteLine("2 - Monitorar Memória");
                Console.WriteLine("3 - Fazer Backup");
                Console.WriteLine("4 - Organizar Arquivos");
                Console.WriteLine("5 - Diagnóstico");
                Console.WriteLine("6 - Executar Todas");
                Console.WriteLine("7 - Mostrar Logs");
                Console.WriteLine("0 - Sair");

                Console.Write("Escolha: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            rotinas[0].Executar();
                            break;

                        case 2:
                            rotinas[1].Executar();
                            break;

                        case 3:
                            rotinas[2].Executar();
                            break;

                        case 4:
                            rotinas[3].Executar();
                            break;

                        case 5:
                            rotinas[4].Executar();
                            break;

                        case 6:
                            foreach (IRotina rotina in rotinas)
                            {
                                rotina.Executar();
                            }
                            break;

                        case 7:
                            logs.MostrarLogs();
                            break;

                        case 0:
                            Console.WriteLine("Encerrando sistema...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    opcao = -1;
                }

                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();

            } while (opcao != 0);
        }
    }
}