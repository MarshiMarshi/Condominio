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
    public partial class frmMoradorView : Form, IMoradorView
    {
        public frmMoradorView()
        {
            InitializeComponent();
        }

        private bool isSucessful;
        private bool isEditing;
        private bool isSearching;

        private static frmMoradorView instance;
        private void AssociateAndRaiseViewEvents()
        {
            btnPesquisar.Click += delegate { PesquisaEvent?.Invoke(this, EventArgs.Empty); };
            txtNomePesquisa.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    PesquisaEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSalvar.Click += delegate { SalvaEvent?.Invoke(this, EventArgs.Empty); };
            btnLimpar.Click += delegate { CancelaEvent?.Invoke(this, EventArgs.Empty); };
            //Others
        }

        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public string Rg
        {
            get { return mtxRG.Text; }
            set { mtxRG.Text = value; }
        }

        public string Cpf
        {
            get { return mtxCPF.Text; }
            set { mtxCPF.Text = value; }
        }

        public string Bloco
        {
            get { return cmbBloco.Text; }
            set { cmbBloco.Text = value; }
        }

        public string Apartamento
        {
            get { return txtApartamento.Text; }
            set { txtApartamento.Text = value; }
        }

        public string NomePesquisa
        {
            get { return txtNomePesquisa.Text; }
            set { txtNomePesquisa.Text = value; }
        }

        public string CpfPesquisa
        {
            get { return mtxCPFPesquisa.Text; }
            set { mtxCPFPesquisa.Text = value; }
        }

        public string RgPesquisa
        {
            get { return mtxRGPesquisa.Text; }
            set { mtxRGPesquisa.Text = value; }
        }

        public string BlocoPesquisa
        {
            get { return cmbBlocoPesquisa.Text; }
            set { cmbBlocoPesquisa.Text = value; }
        }

        public string ApartamentoPesquisa
        {
            get { return txtApartamentoPesquisa.Text; }
            set { txtApartamentoPesquisa.Text = value; }
        }

        public string NomeEdicao
        {
            get { return txtNomeEdicao.Text; }
            set { txtNomeEdicao.Text = value; }
        }

        public string CpfEdicao
        {
            get { return mtxCPFEdicao.Text; }
            set { mtxCPFEdicao.Text = value; }
        }

        public string RgEdicao
        {
            get { return mtxRGEdicao.Text; }
            set { mtxRGEdicao.Text = value; }
        }

        public string BlocoEdicao
        {
            get { return cmbBlocoEdicao.Text; }
            set { cmbBlocoEdicao.Text = value; }
        }

        public string ApartamentoEdicao
        {
            get { return txtApartamentoEdicao.Text; }
            set { txtApartamentoEdicao.Text = value; }
        }

        public bool IsEditing
        {
            get { return isEditing; }
            set { isEditing = value; }
        }

        public bool IsSearching
        { 
            get { return isSearching; }
            set { isSearching = value; }
        }

        public bool IsSucessful
        {
            get { return isSucessful; }
            set { isSucessful = value; }
        }

        internal static frmMoradorView GetInstance(frmMainView mainView)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmMoradorView();
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
        
        public event EventHandler PesquisaEvent;
        public event EventHandler AdicionaEvent;
        public event EventHandler EditaEvent;
        public event EventHandler SalvaEvent;
        public event EventHandler CancelaEvent;
        public event EventHandler DeleteEvent;
    }
}
