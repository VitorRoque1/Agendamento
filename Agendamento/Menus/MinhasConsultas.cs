using Agendamento.Clinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento.Menus
{
    internal class MinhasConsultas: Menu
    {
        public override void Executar(Dictionary<string, Consulta> consultasAgendadas)
        {
            base.Executar(consultasAgendadas);
            ExibirTituloDaOpcao("Exibindo todas consultas");
            foreach (string consulta in consultasAgendadas.Keys)
            {

                Console.WriteLine($"Sua consulta de {consulta}: está marcada");
                Console.WriteLine("==============================================================");

            }


            Console.WriteLine("Deseja desmarcar sua consulta: ");
            string[] desmarcar = { "\n[1] - Sim", "[2] - Não", "[3] - Voltar" };
          
            for (int i = 0; i < desmarcar.Length; i++)
            {
                Console.WriteLine(desmarcar[i]);
            }
            Console.Write("\nInforme sua opção: ");


            string opcao = Console.ReadLine()!;
            int opcaoEscolhida = int.Parse(opcao);
           switch (opcaoEscolhida)
            {
                case 1:
 
                     // Remover arrays 

                    foreach (string consulta in consultasAgendadas.Keys)
                    {
                        consultasAgendadas.Remove(consulta);
                        Console.WriteLine("\nSua consulta foi desmarcada com sucesso: ");
                        Console.WriteLine("\nVoltando ao menu, aguarde...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        // Logo de volta ao menu
                        Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                        Console.WriteLine("                                       -------------------------------------");

                    }


                    break;

                case 2:
                    // Voltar ao menu
                    Console.WriteLine("\nVoltando ao menu, aguarde...");
                    Thread.Sleep(2500);;
                    Console.Clear();
                    // Logo de volta ao menu
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");

                    break;

                case 3:
                    // Voltar ao menu
                    Console.WriteLine("\nVoltando ao menu, aguarde...");
                    Thread.Sleep(2500); ;
                    Console.Clear();
                    // Logo de volta ao menu
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");

                    break;
            }


            
        }
 
    }
}
