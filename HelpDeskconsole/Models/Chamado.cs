using HelpDeskconsole.Enums;

namespace HelpDeskconsole.Models
{
    public class Chamado
    {
          public int Id { get; set; }
          public string Titulo { get; set; }
          public string Descricao { get; set; }
          public string Departamento { get; set; }
          public string Email { get; set; }
          public PrioridadeChamado Prioridade { get; set; }
          public StatusChamado Status  { get; set; }
          public  DateTime DataAbertura { get; set; }


        public Chamado(

               string titulo,
               string descricao,
               string departamento,
               string email,
               PrioridadeChamado prioridade)
        {
            Titulo = titulo;
            Descricao = descricao;
            Departamento = departamento;
            Email = email;
            Prioridade = prioridade;

            Status = StatusChamado.Aberto;
            DataAbertura = DateTime.Now;
        }

       
    }
}
