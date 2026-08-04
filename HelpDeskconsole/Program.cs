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

        if (string.IsNullOrWhiteSpace(titulo))
        {
            Console.WriteLine("O título é obrigatório. Por favor, insira um titulo válido.");
            continue;
        }

        Console.Write("Descrição: ");
        string descricao = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(descricao))
        {
            Console.WriteLine("A descrição é obrigatoria. Por favor, insira uma descrição válida.");
            continue;
        }
        Console.Write("Departamento: ");
        string departamento = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(departamento))
        {
            Console.WriteLine("O depatamento é obrigatorio, Por favor insira um departamento.");
            continue;

        }
        Console.Write("E-mail:");
        string email = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(email)) 
        {
            Console.WriteLine("O e-mail é obrigatorio, Por favor insira um e-mail.");
            continue;
        }
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

        Chamado chamado = new Chamado(
            titulo,
            descricao,
            departamento,
            email,
            prioridade
            );


        service.AbrirChamado(chamado);
        Console.WriteLine($"Chamado criado com sucesso! ID: {chamado.Id}");

    }
    else if (opcao == "2")
    {

        var chamados = service.ListaChamado();

        if (chamados == null || chamados.Count == 0)
        {
            Console.WriteLine("Nenhum chamado cadastrado.");
            continue;
        }

        foreach (var chamado in chamados)
        {
            Console.WriteLine($"ID: {chamado.Id}");
            Console.WriteLine($"Título: {chamado.Titulo}");
            Console.WriteLine($"Prioridade: {chamado.Prioridade}");
            Console.WriteLine($"Status: {chamado.Status}");
            Console.WriteLine($"------------------------------");
        }

    }
    else if (opcao == "3")
    {
        Console.WriteLine("Busca Chamado Pelo Id");
        int Id = int.Parse(Console.ReadLine()!);

        var chamadoEncontrado = service.BuscaPorId(Id);

        if (chamadoEncontrado == null)
        {
            Console.WriteLine("Chamado não encontrado.");
        }
        else
        {

            Console.WriteLine($"ID: {chamadoEncontrado.Id}");
            Console.WriteLine($"Títilo: {chamadoEncontrado.Titulo}");
            Console.WriteLine($"Descrição: {chamadoEncontrado.Descricao}");
            Console.WriteLine($"EmailSolicitante: {chamadoEncontrado.EmailSolicitante}");
            Console.WriteLine($"Prioridade: {chamadoEncontrado.Prioridade}");
            Console.WriteLine($"Status: {chamadoEncontrado.Status}");


        }

        Console.WriteLine($"Chamado Recebido: {Id}");
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Informe o ID do chamado: ");
        int id = int.Parse(Console.ReadLine()!);

        bool fechado = service.FecharChamado(id);

        if (!fechado)
        {
            Console.WriteLine("Chamado não encontrado. ");
        }
        else
        {
            Console.WriteLine($"Chamado {id} fechado com sucesso.");
        }
    }
}
