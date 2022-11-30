using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.Model;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Repository;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.Presenter
{
    public class EncomendaPresenter
    {
        public IEncomendaView view;
        public IEncomendaRepository repository;
        private BindingSource encomendasbindingSource;
        private IEnumerable<Encomenda> encomendaList;
        
        public EncomendaPresenter(IEncomendaView view, IEncomendaRepository repository)
        {
            this.encomendasbindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            SetBindingSource(encomendasbindingSource);
            this.view.Show();
        }

        private void SetBindingSource(BindingSource moradoresBindingSource)
        {
            encomendaList = repository.GetAll();
            moradoresBindingSource.DataSource = encomendaList;
        }
    }
}
