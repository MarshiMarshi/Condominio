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
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnPesquisar.Click += delegate { PesquisarEvent?.Invoke(this, EventArgs.Empty); };
            btnSalvar.Click += delegate { SalvarEvent?.Invoke(this, EventArgs.Empty); };
            btnLimpar.Click += delegate { CancelarEvent?.Invoke(this, EventArgs.Empty); };
            btnEditar.Click += delegate { EditarEvent?.Invoke(this, EventArgs.Empty); };
            btnSalvar.Click += delegate
            {
                SalvarEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    //tabCRUD.TabPages.Remove(tpCreate);
                    //tabCRUD.TabPages.Add(tpUpdate);
                }
                MessageBox.Show(mensagem);
            };

            btnCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                //tabCRUD.TabPages.Remove(tpUpdate);
                //tabCRUD.TabPages.Add(tpCreate);
            };
        }

        private static FrmEncomendaView instance;
        string id;
        private bool isSuccessful;
        private string mensagem;

        public string Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Status
        {
            get { return Status; }
            set { Status = value; } 
        }

        public string Armazenamento 
        {
            get { return cmbLocalArmazem.Text; }
            set { cmbLocalArmazem.Text = value; }
        }

        public string DataChegada 
        {
            get { return mtxDataChegada.Text; }
            set { mtxDataChegada.Text = value; }
        }

        public string DataEntrega 
        { 
            get { return mtxDataEntrega.Text; }
            set { mtxDataEntrega.Text = value; }
        }

        public string NomeDestinatario
        {
            get { return txtNomeDestinatario.Text; }
            set { txtNomeDestinatario.Text = value; }
        }

        public string BlocoDestinatario
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string ApartamentoDestinatario
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
            get { return mensagem; };
            set { this.mensagem = value; }; 
        }
        public int GuiaSelecionada
        {
            get { return tabCRUD.SelectedIndex; }
            set { tabCRUD.SelectedIndex = value; }
        }

        public event EventHandler CancelarEvent;

        public event EventHandler SalvarEvent;
        public event EventHandler limparEvent;
        public event EventHandler EditarEvent;
        public event EventHandler PesquisarEvent;

        internal static FrmEncomendaView GetInstance(frmMainView mainView)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmEncomendaView();
                instance.MdiParent = mainView;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.Show();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public void SetEncomendaListBindingSource(BindingSource encomendaList)
        {
            dgvEncomendas.DataSource = encomendaList;
        }
    }
}
