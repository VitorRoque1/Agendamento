
using Agendamento.Clinica;
using Agendamento.Menus;

Dictionary<string, Consulta> consultasAgendadas = new();

Dictionary <int, Menu > opcoes = new();
opcoes.Add(1, new AgendarConsulta());
opcoes.Add(2, new MinhasConsultas());

void ExibirLogo()
{
    Console.WriteLine("                                       Seja Bem-Vindo(a) a Clinica Fique Bem             ");
    Console.WriteLine("                                       -------------------------------------");
}
void BemVindo()
{
    ExibirLogo();
    Console.Write("Olá, informe seu nome: ");
    string nome = Console.ReadLine()!;
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    Console.WriteLine($"\nOlá, Sr(a) {nome} o que deseja?: ");
}
BemVindo();

// Menu
void Menus1()
{

    Console.WriteLine("\n[1] Agendar Consultas  ");
    Console.WriteLine("[2] Minhas Consultas");
    Console.WriteLine("[3] Sair");

    Console.Write("\nInforme sua Opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoNumerica))
    {
        Menu menu = opcoes[opcaoNumerica];
        menu.Executar(consultasAgendadas);
        if (opcaoNumerica > 0) Menus1();
    }

  
}


  



Menus1();
