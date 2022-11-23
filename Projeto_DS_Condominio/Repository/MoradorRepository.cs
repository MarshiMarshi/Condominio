using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Model;

namespace Projeto_DS_Condominio.Repository
{
    public class MoradorRepository : RepositoryBase, IMoradorRepository
    {
        public MoradorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Adicionar(Morador morador)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Morador morador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByStatus()
        {
            throw new NotImplementedException();
        }
    }
}
