using HelpDeskconsole.Enums;


namespace HelpDeskconsole.Models
{
    public class Chamado
    {
          public int Id { get; set; }
          public string Titulo { get; set; }
          public string Descricao { get; set; }
          public string Departamento { get; set; }
          public string EmailSolicitante { get; set; }
          public PrioridadeChamado Prioridade { get; set; }
          public StatusChamado Status  { get; set; }
          public  DateTime DataAbertura { get; set; }


        public Chamado(

               string titulo,
               string descricao,
               string departamento,
               string emailSolicitante,
               PrioridadeChamado prioridade)
        {
            Titulo = titulo;
            Descricao = descricao;
            Departamento = departamento;
            EmailSolicitante = emailSolicitante;
            Prioridade = prioridade;

            Status = StatusChamado.Aberto;
            DataAbertura = DateTime.Now;
        }

    }
}
