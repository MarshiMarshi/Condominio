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
            btnPesquisar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtNomePesquisa.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            btnSalvar.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnLimpar.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
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
            set { value = mtxCPFPesquisa.Text; }
        }

        public string RgPesquisa
        {
            get { return mtxRGPesquisa.Text; }
            set { value = mtxRGPesquisa.Text; }
        }

        public string BlocoPesquisa
        {
            get { return cmbBlocoPesquisa.Text; }
            set { value = cmbBlocoPesquisa.Text; }
        }

        public string ApartamentoPesquisa
        {
            get { return txtApartamentoPesquisa.Text; }
            set { value = txtApartamentoPesquisa.Text; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
    }
}

