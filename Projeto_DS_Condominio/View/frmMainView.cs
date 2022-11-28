using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            btnEncomenda.Click += delegate { ShowEncomendaView?.Invoke(this, EventArgs.Empty); };
            btnMorador.Click += delegate { ShowMoradorView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowEncomendaView;
        public event EventHandler ShowMoradorView;
    }
}
