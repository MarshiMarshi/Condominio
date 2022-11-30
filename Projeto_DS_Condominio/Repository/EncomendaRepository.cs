using Projeto_DS_Condominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DS_Condominio.Repository
{
    public class EncomendaRepository : RepositoryBase, IEncomendaRepository
    {
        public EncomendaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Adicionar(Encomenda encomenda)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Encomenda encomenda)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
