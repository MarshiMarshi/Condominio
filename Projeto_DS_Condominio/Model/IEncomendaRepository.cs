using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.Model
{
    public interface IEncomendaRepository
    {
        void Adicionar(Encomenda encomenda);
        void Editar(Encomenda encomenda);
        void Delete(int id);
        IEnumerable<Encomenda> GetAll();
    }
}
