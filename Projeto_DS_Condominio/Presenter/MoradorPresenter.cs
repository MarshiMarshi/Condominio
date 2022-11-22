using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Model;

namespace Projeto_DS_Condominio.Presenter
{
    public class MoradorPresenter
    {
        public IMoradorView view;
        public IMoradorRepository repository;
        private IEnumerable<Morador> moradorList;

        public MoradorPresenter(IMoradorView view, IMoradorRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }
    }
}
