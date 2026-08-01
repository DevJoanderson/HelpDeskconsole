using HelpDeskconsole.Models;
using HelpDeskconsole.Enums;
using HelpDeskconsole.Services;
using System.Net.Security;

ChamadoService service = new();

bool executando = true;

while (executando)
{
    Console.WriteLine("1 - Abrir chamado");
    Console.WriteLine("2 - Listar chamados");
    Console.WriteLine("3 - Buscar chamado por ID");
    Console.WriteLine("4 - Fechar chamado");
    Console.WriteLine("0 - Sair");

    Console.Write("Escolha uma opção: ");
    string? opcao = Console.ReadLine();

    if (opcao == "0")
    {
        executando = false;
        Console.WriteLine("Programa encerrado.");

    }
    else if (opcao == "1")
    {
        Console.WriteLine("Título: ");
        string titulo = Console.ReadLine()!;
        Console.Write("Descrição: ");
        string descricao = Console.ReadLine()!;
        Console.Write("Departamento: ");
        string departamento = Console.ReadLine()!;
        Console.Write("E-mail:");
        string email = Console.ReadLine()!;
        
        Chamado chamado = new Chamado(
            titulo,
            descricao,
            departamento,
            email,
            prioridade
            );

        Console.WriteLine("Escolha a prioridade:");
        Console.WriteLine("1 - Baixa");
        Console.WriteLine("2 - Média");
        Console.WriteLine("3 - Alta");
        Console.WriteLine("4 - Urgente");

        int opcaoPrioridade = int.Parse(Console.ReadLine()!);
        PrioridadeChamado prioridade;

        switch (opcaoPrioridade)
        {
            case 1:
                prioridade = PrioridadeChamado.Baixa;
                break;
            case 2:
                prioridade = PrioridadeChamado.Media;
                break;
            case 3:
                prioridade = PrioridadeChamado.Alta;
                break;
            case 4:
                prioridade = PrioridadeChamado.Urgente;
                break;
            default:
                prioridade = PrioridadeChamado.Baixa;
                break;

        }


        service.AbrirChamado(chamado);

    }
    else if(opcao == "2")
    {
        Console.WriteLine("Lista o Chamado");
        var chamados = service.ListaChamado();
        Console.WriteLine($"Chamado Listado: {chamados}");

    }
    else if (opcao == "3")
    {
        Console.WriteLine("Busca Chamado Pelo Id");
        int Id = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Chamado Recebido: {Id}");
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Fechar Chamado");
        int id = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Chamado Fechado");
    }
}
