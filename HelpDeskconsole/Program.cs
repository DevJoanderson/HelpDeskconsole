using HelpDeskconsole.Models;
using HelpDeskconsole.Enums;
using HelpDeskconsole.Services;

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
            Console.WriteLine("O título é obrigatório. Insira um titulo válido.");
            continue;
        }

        Console.Write("Descrição: ");
        string descricao = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(descricao))
        {
            Console.WriteLine("A descrição é obrigatoria. Insira uma descrição válida.");
            continue;
        }
        Console.Write("Departamento: ");
        string departamento = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(departamento))
        {
            Console.WriteLine("O depatamento é obrigatorio, Insira um departamento válido.");
            continue;

        }
        Console.Write("E-mail:");
        string email = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(email))
        {
            Console.WriteLine("O e-mail é obrigatorio, Insira um e-mail válido.");
            continue;
        }

        if (!email.Contains("@") || !email.Contains("."))
        {
            Console.WriteLine("E-mail inválido, enforme um e-mail válido");
            continue;
        }

        Console.WriteLine("Escolha a prioridade:");
        Console.WriteLine("1 - Baixa");
        Console.WriteLine("2 - Média");
        Console.WriteLine("3 - Alta");
        Console.WriteLine("4 - Urgente");

        bool prioridadeValida = int.TryParse(
            Console.ReadLine(),
            out int opcaoPrioridade
            );

        if (!prioridadeValida)
        {
            Console.WriteLine("Digite um número válido para a prioridade.");
            continue;
        }

        if (opcaoPrioridade < 1 || opcaoPrioridade > 4)
        {
            Console.WriteLine("Prioridade inválida. Escolha uma opção de 1 a 4.");
            continue;
        }

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
        bool IdValido = int.TryParse(
            Console.ReadLine(),
            out int Id

            );

        if (!IdValido)
        {
            Console.WriteLine("Digite um numéro valido para o ID.");
            continue;
        }

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
            Console.WriteLine($"Email: {chamadoEncontrado.Email}");
            Console.WriteLine($"Prioridade: {chamadoEncontrado.Prioridade}");
            Console.WriteLine($"Status: {chamadoEncontrado.Status}");

        }

        Console.WriteLine($"Chamado Recebido: {Id}");
    }
    else if (opcao == "4")
    {
        Console.WriteLine("Informe o ID do chamado: ");
        bool idValido = int.TryParse(
            Console.ReadLine(),
            out int id
            );
        if (!idValido)
        {
            Console.WriteLine("Informe o ID do chamado: ");
            continue;
        }

        bool fechado = service.FecharChamado(id);

        if (!fechado)
        {
            Console.WriteLine("Chamado não encontrado. ");
        }
        else
        {
            Console.WriteLine($"Chamado {id} fechado com sucesso.");
        }
    }else if (opcao == "5")
    {
        Console.WriteLine("Informe o Id do chamado que deseja excluir: ");
        bool idValido = int.TryParse(
            Console.ReadLine(),
            out int id
            );
        if (!idValido)
        {
            Console.WriteLine("Id ínvalido.");
            continue;
        }
        bool chamadoExcluido = service.ExcluirChamado(id);

        if(chamadoExcluido)
        {
            Console.WriteLine("Chamado excluido com sucesso.");
        }
        else
        {
            Console.WriteLine("Chamado não encontrado.");
        }
    }
}