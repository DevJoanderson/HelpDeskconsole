using HelpDeskconsole.Models;

namespace HelpDeskconsole.Repositories
{
    public class ChamadoRepository {

        private List<Chamado> _chamados = new();

        public void Cadastrar(Chamado chamado)
        {
            _chamados.Add(chamado);
        }

        public List<Chamado> Listar()
        {
            return _chamados;
        }

        public Chamado? BuscarPorId(int id) { 
        
          foreach (var chamado in _chamados) { 
             
                if(chamado.Id == id)
                {
                    return chamado;
                }
           
            }

            return null; 
        }

        public int GerarId()
        {
            return _chamados.Count + 1;
        
        }

    }

}
