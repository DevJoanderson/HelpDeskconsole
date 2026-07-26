using HelpDeskconsole.Enums;
using HelpDeskconsole.Models;
using HelpDeskconsole.Repositories;

namespace HelpDeskconsole.Services
{
    public class ChamadoService
    {
        private ChamadoRepository _repository = new();


        public void AbrirChamado(Chamado chamado)
        {
            _repository.Cadastrar(chamado);
        }

        public bool FecharChamado(int id)
        {
            var chamado = _repository.BuscarPorId(id);

            if (chamado == null)
            {
                return false;
            }
            chamado.Status = StatusChamado.Concluido;
            return true;
        }

    }


}   
