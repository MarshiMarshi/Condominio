using Projeto_DS_Condominio.Model;
using Projeto_DS_Condominio.Presenter;
using Projeto_DS_Condominio.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.View
{
    public partial class frmMainView : Form, IMainView
    {
        public frmMainView()
        {
            InitializeComponent();
            btnEncomenda.Click += delegate {
                IEncomendaView encomendaView = FrmEncomendaView.GetInstance((frmMainView)this);
                IEncomendaRepository encomendaRepository = new EncomendaRepository(ConfigurationManager.ConnectionStrings["projeto_ds_condominioConnection"].ConnectionString);
                new EncomendaPresenter(encomendaView, encomendaRepository);
            };
            btnMorador.Click += delegate {
                IMoradorView moradorView = frmMoradorView.GetInstance((frmMainView)this);
                IMoradorRepository moradorRepository = new MoradorRepository(ConfigurationManager.ConnectionStrings["projeto_ds_condominioConnection"].ConnectionString);
                new MoradorPresenter(moradorView, moradorRepository);
            };
        }

        public event EventHandler ShowEncomendaView;
        public event EventHandler ShowMoradorView;
    }
}
