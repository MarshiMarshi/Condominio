using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Enums;

namespace Projeto_DS_Condominio.Model
{
    public interface IEncomendaRepository
    {
        void Adicionar(Encomenda encomenda);
        void Editar(Encomenda encomenda);

        // Pesquisas
        IEnumerable<Encomenda> GetAll();
        IEnumerable<Encomenda> GetByValue(string nomeDestinatario);
        IEnumerable<Encomenda> GetByValue(StatusEncomendaEnum status);
        IEnumerable<Encomenda> GetByValue(DateTime dataEntre);
        IEnumerable<Encomenda> GetByValue(string nomeDestinatario, StatusEncomendaEnum status);
        IEnumerable<Encomenda> GetByValue(string nomeDestinatario, DateTime dataEntre);
        IEnumerable<Encomenda> GetByValue(StatusEncomendaEnum status, DateTime dataEntre);
        IEnumerable<Encomenda> GetByValue(string nomeDestinatario, StatusEncomendaEnum status, DateTime dataEntre);
    }
}
