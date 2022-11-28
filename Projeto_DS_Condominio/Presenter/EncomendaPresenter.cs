using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Model;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Repository;

namespace Projeto_DS_Condominio.Presenter
{
    public class EncomendaPresenter
    {
        public EncomendaPresenter(IEncomendaView view, IEncomendaRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }

        public IEncomendaView view;
        public IEncomendaRepository repository;
        private IEnumerable<Encomenda> encomendaList;
    }
}
