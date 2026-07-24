using HelpDeskconsole.Repositories;
using HelpDeskconsole.Models;

namespace HelpDeskconsole.Services
{
    public class ChamadoService
    {
        private ChamadoRepository _repository = new();


        public void AbrirChamado(Chamado chamado)
        {
            _repository.Cadastrar(chamado);
        }

    }


}   
