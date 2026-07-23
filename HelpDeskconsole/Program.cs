using HelpDeskconsole.Models;
using HelpDeskconsole.Enums;

var chamado = new Chamado(

    "O computador nao liga",
    "computador do finaceiro",
    "Finaceiro",
    "usuario@email.com",
    PrioridadeChamado.Alta

    );

Console.WriteLine(chamado.Titulo);
Console.WriteLine(chamado.Status);
Console.WriteLine(chamado.DataAbertura);