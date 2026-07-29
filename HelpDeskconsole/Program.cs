using HelpDeskconsole.Models;
using HelpDeskconsole.Enums;
using HelpDeskconsole.Services;

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
}


//service.BuscaPorId(1);
Console.WriteLine(chamado.Titulo);
Console.WriteLine(chamado.Status);
Console.WriteLine(chamado.DataAbertura);