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
    public partial class FrmEncomendaView : Form, IEncomendaView
    {
        public FrmEncomendaView()
        {
            InitializeComponent();
        }

        public string Id 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string Status
        {
            get { return Status; }
            set { Status = value; } 
        }

        public string Armazenamento 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public string DataChegada 
        {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string DataEntrega 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string Destinatario
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public string DescricaoAusente 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public string DescricaoDevolutiva
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public string ProcurarId 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public bool Editar 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public bool Concluido 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Mensagem 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public event EventHandler SalvarEvent;
        public event EventHandler limparEvent;
        public event EventHandler EditarEvent;
        public event EventHandler PesquisarEvent;

        public void SetEncomendaListBindingSourc(BindingSource encomendaList)
        {
            pnlEncomendas.DataSourc = encomendaList;
        }
    }
}
