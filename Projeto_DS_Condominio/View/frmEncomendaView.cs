using Projeto_DS_Condominio.Enums;
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
    public partial class frmEncomendaView : Form, IEncomendaView
    {
        public frmEncomendaView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSalvar.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            btnCancelar.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
            btnLimpar.Click += delegate { CleanTextsEvent?.Invoke(this, EventArgs.Empty); };
            btnPesquisar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string NomeDestinatario {
            get { return txtNomeDestinatario.Text; }
            set { txtNomeDestinatario.Text = value; }
        }

        public BlocoEnum Bloco {
            get { return (BlocoEnum)cmbBloco.SelectedItem; }
            set { cmbBloco.Items.Add(value); }
        }

        public string Apartamento {
            get { return txtApartamento.Text; }
            set { txtApartamento.Text = value; }
        }

        public LocalArmazenamentoEnum LocalArmazem {
            get { return (LocalArmazenamentoEnum)cmbLocalArmazem.SelectedItem; }
            set { cmbLocalArmazem.Items.Add(value); }
        }

        public DateTime DataChegada {
            get { return DateTime.Parse(mtxDataChegada.Mask); }
            set { mtxDataChegada.Mask = value.Date.ToString(); }
        }

        public StatusEncomendaEnum Status {
            get { return (StatusEncomendaEnum)cmbStatus.SelectedItem; }
            set { cmbStatus.Items.Add(value); }
        }

        public DateTime DataEntrega {
            get { return DateTime.Parse(mtxDataEntrega.Mask); }
            set { mtxDataEntrega.Mask = value.Date.ToString(); }
        }

        public MotivoEnum Motivo {
            get { return (MotivoEnum)cmbMotivo.SelectedItem; }
            set { cmbMotivo.Items.Add(value); }
        }

        public DateTime DataDevolucao {
            get { return DateTime.Parse(mtxDataDevolucao.Mask); }
            set { mtxDataDevolucao.Mask = value.Date.ToString(); }
        }

        public string NomeDestinatarioPesquisa {
            get { return txtNomeDestinatarioPesquisa.Text; }
            set { txtNomeDestinatarioPesquisa.Text = value; }
        }

        public DateTime DataInicio {
            get { return dtpDataInicio.Value.Date; }
            set { dtpDataInicio.Value = value; }
        }

        public IntervaloEnum Intervalo {
            get { return (IntervaloEnum)cmbIntervalo.SelectedItem; }
            set { cmbIntervalo.Items.Add(value); }
        }

        public string DataEntre {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public StatusEncomendaEnum StatusPesquisa {
            get { return (StatusEncomendaEnum)cmbStatusPesquisa.SelectedItem; }
            set { cmbStatusPesquisa.Items.Add(value); }
        }

        public event EventHandler SearchEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler CleanTextsEvent;

        public void SetEncomendaBindingSource(BindingSource encomendaList)
        {
            throw new NotImplementedException();
        }

        private static frmEncomendaView instance;
        public static frmEncomendaView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmEncomendaView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
