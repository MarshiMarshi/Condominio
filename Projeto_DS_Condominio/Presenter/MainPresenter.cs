using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_DS_Condominio.View;
using Projeto_DS_Condominio.Model;
using Projeto_DS_Condominio.Repository;

namespace Projeto_DS_Condominio.Presenter
{
    public class MainPresenter
    {
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowMoradorView += ShowMoradorView;
            this.mainView.ShowEncomendaView += ShowEncomendaView;
        }

        private IMainView mainView;
        private readonly string sqlConnectionString;

        private void ShowEncomendaView(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowMoradorView(object sender, EventArgs e)
        {
            IMoradorView moradorView = frmMoradorView.GetInstance((frmMainView)mainView);
            IMoradorRepository moradorRepository = new MoradorRepository();
            new MoradorPresenter(moradorView, moradorRepository);
        }
    }
}
