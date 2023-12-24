using Agendamento.Clinica;


namespace Agendamento.Menus
{
    internal class AgendarConsulta: Menu
    {
        public override void Executar(Dictionary<string, Consulta> consultasAgendadas)

            
        {

            base.Executar(consultasAgendadas);
            Console.WriteLine("                                               Especialidades ");
            Console.WriteLine("                                               --------------");

            string[] consultas = { "- Cardiologista", "- Dermatologista", "- Endrocrino", "- Clinica medica", "- Nutrição"};
            for(int i = 0; i < consultas.Length; i++)
            {
                Console.WriteLine(consultas[i]);
            }
            Console.Write("\n Digite a especilidade da consulta: ");
            string consulta = Console.ReadLine()!;



            switch (consulta)
            {
                case "Cardiologista":
                    Console.WriteLine("\nCardiologista: Horarios Disponiveis");
                    string[] horarios = {"\n[1] Janeiro dia 05/01/2024 as 11:30", "[2] Janeiro dia 10/01/2024 as 10:30", "[3] Janeiro dia 15/01/2024 as 09:30"};
                    for (int i = 0; i < horarios.Length; i++)
                    {
                        Console.WriteLine(horarios[i]);


                    }
                    Console.Write("\nInforme o nome da consulta data e hora: ");
                    string Agendamento0 = Console.ReadLine();
                    Consulta horario0 = new Consulta(Agendamento0);
                    consultasAgendadas.Add(Agendamento0, horario0);

                    Console.WriteLine($"\nA consulta de Cardiologista foi marcada com sucesso!");
                    Thread.Sleep(2000);
                            Console.Clear();
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");
            


            break;


                case "Dermatologista":
                    Console.WriteLine("\nDermatologista: Horarios Disponiveis");
                    string[] horarios1 = { "\n[1] Janeiro dia 05/01/2024 as 11:30", "[2] Janeiro dia 10/01/2024 as 10:30", "[3] Janeiro dia 15/01/2024 as 09:30" };
                    for (int i = 0; i < horarios1.Length; i++)
                    {
                        Console.WriteLine(horarios1[i]);


                    }
                    Console.Write("\nInforme o nome da consulta data e hora: ");
                    string Agendamento2 = Console.ReadLine();
                    Consulta horario2 = new Consulta(Agendamento2);
                    consultasAgendadas.Add(Agendamento2, horario2);

                    Console.WriteLine($"\nA consulta de Dermalogista foi marcada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    // Logo de volta ao menu

                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");
                    break;

                case "Endrocrino":
                    Console.WriteLine("\nEndrocrino: Horarios Disponiveis");
                    string[] horarios2 = { "\n[1] Janeiro dia 05/01/2024 as 11:30", "[2] Janeiro dia 10/01/2024 as 10:30", "[3] Janeiro dia 15/01/2024 as 09:30" };
                    for (int i = 0; i < horarios2.Length; i++)
                    {
                        Console.WriteLine(horarios2[i]);


                    }
                    Console.Write("\nInforme o nome da consulta data e hora: ");
                    string Agendamento3 = (Console.ReadLine());
                    Consulta horario3 = new Consulta(Agendamento3);

                    consultasAgendadas.Add(Agendamento3, horario3);
                    Console.WriteLine($"\nA consulta de Endrocrino foi marcada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();

                    // Logo de volta ao menu
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");

                    break;

                case "Clinico geral":
                    Console.WriteLine("\nClinico geral: Horarios Disponiveis");
                    string[] horarios3 = { "\n[1] Janeiro dia 05/01/2024 as 11:30", "[2] Janeiro dia 10/01/2024 as 10:30", "[3] Janeiro dia 15/01/2024 as 09:30" };
                    for (int i = 0; i < horarios3.Length; i++)
                    {
                        Console.WriteLine(horarios3[i]);


                    }
                    Console.Write("\nInforme o nome da consulta data e hora: ");
                    string Agendamento4 = (Console.ReadLine());
                    Consulta horario4 = new Consulta(Agendamento4);

                    consultasAgendadas.Add(Agendamento4, horario4);
                    Console.WriteLine($"\nA consulta Clinico geral foi marcada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();

                    // Logo de volta ao menu
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");

                    break;

                case "Nutricao":
                    Console.WriteLine("\n Nutrição: Horarios Disponiveis");
                    string[] horarios4 = { "\n[1] Janeiro dia 05/01/2024 as 11:30", "[2] Janeiro dia 10/01/2024 as 10:30", "[3] Janeiro dia 15/01/2024 as 09:30" };
                    for (int i = 0; i < horarios4.Length; i++)
                    {
                        Console.WriteLine(horarios4[i]);


                    }
                    Console.Write("\nInforme o nome da consulta data e hora: ");
                    string Agendamento5 = (Console.ReadLine());
                    Consulta horario5 = new Consulta(Agendamento5);

                    consultasAgendadas.Add(Agendamento5, horario5);
                    Console.WriteLine($"\nA consulta de Nutrição foi marcada com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();

                    // Logo de volta ao menu
                    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
                    Console.WriteLine("                                       -------------------------------------");

                    break;

            }






        }
    }
    
}
