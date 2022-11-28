using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Enums;
using Projeto_DS_Condominio.Model;

namespace Projeto_DS_Condominio.Repository
{
    public class EncomendaRepository : RepositoryBase, IEncomendaRepository
    {
        public void Adicionar(Encomenda encomenda)
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

        public IEnumerable<Encomenda> GetByValue(string nomeDestinatario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(StatusEncomendaEnum status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(DateTime dataEntre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(string nomeDestinatario, StatusEncomendaEnum status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(string nomeDestinatario, DateTime dataEntre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(StatusEncomendaEnum status, DateTime dataEntre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Encomenda> GetByValue(string nomeDestinatario, StatusEncomendaEnum status, DateTime dataEntre)
        {
            throw new NotImplementedException();
        }
    }
}
