using HelpDeskconsole.Models;
using HelpDeskconsole.Enums;
using HelpDeskconsole.Services;
using System.Net.Security;

var chamado = new Chamado(

    "O computador nao liga",
    "computador do finaceiro",
    "Finaceiro",
    "usuario@email.com",
    PrioridadeChamado.Alta

    );
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
        Console.WriteLine("Título");
        string titulo = Console.ReadLine()!;

        Console.WriteLine($"Título informado: {titulo}"); 
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


//service.BuscaPorId(1);
Console.WriteLine(chamado.Titulo);
Console.WriteLine(chamado.Status);
Console.WriteLine(chamado.DataAbertura);