
namespace Projeto_DS_Condominio.View
{
    partial class FrmEncomendaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblNomeDestinatario = new System.Windows.Forms.Label();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.lblBloco = new System.Windows.Forms.Label();
            this.txtNomeDestinatario = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpEncomenda = new System.Windows.Forms.GroupBox();
            this.grpDescricao = new System.Windows.Forms.GroupBox();
            this.mtxDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblLocalArmazem = new System.Windows.Forms.Label();
            this.mtxDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mtxDataChegada = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.cmbLocalArmazem = new System.Windows.Forms.ComboBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNomeDestinatarioPesquisa = new System.Windows.Forms.TextBox();
            this.cmbStatusPesquisa = new System.Windows.Forms.ComboBox();
            this.lblStatusPesquisa = new System.Windows.Forms.Label();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblEntre = new System.Windows.Forms.Label();
            this.lblNomeDestinatarioPesquisa = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlEncomendas = new System.Windows.Forms.Panel();
            this.dgvEncomendas = new System.Windows.Forms.DataGridView();
            this.tabCRUD.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.grpDestinatario.SuspendLayout();
            this.grpEncomenda.SuspendLayout();
            this.grpDescricao.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlEncomendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.tpCreate);
            this.tabCRUD.Controls.Add(this.tpUpdate);
            this.tabCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabCRUD.Enabled = false;
            this.tabCRUD.Location = new System.Drawing.Point(0, 0);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.SelectedIndex = 0;
            this.tabCRUD.Size = new System.Drawing.Size(267, 499);
            this.tabCRUD.TabIndex = 11;
            // 
            // tpCreate
            // 
            this.tpCreate.BackColor = System.Drawing.Color.White;
            this.tpCreate.Controls.Add(this.btnLimpar);
            this.tpCreate.Controls.Add(this.grpDestinatario);
            this.tpCreate.Controls.Add(this.btnSalvar);
            this.tpCreate.Controls.Add(this.grpEncomenda);
            this.tpCreate.Location = new System.Drawing.Point(4, 22);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreate.Size = new System.Drawing.Size(259, 473);
            this.tpCreate.TabIndex = 0;
            this.tpCreate.Text = "Criar Encomenda";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(6, 439);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(247, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar Caixas de Texto";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.txtApartamento);
            this.grpDestinatario.Controls.Add(this.lblNomeDestinatario);
            this.grpDestinatario.Controls.Add(this.lblApartamento);
            this.grpDestinatario.Controls.Add(this.cmbBloco);
            this.grpDestinatario.Controls.Add(this.lblBloco);
            this.grpDestinatario.Controls.Add(this.txtNomeDestinatario);
            this.grpDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDestinatario.Location = new System.Drawing.Point(6, 10);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(247, 141);
            this.grpDestinatario.TabIndex = 26;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "Dados do Destinatário";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamento.Location = new System.Drawing.Point(140, 106);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(81, 20);
            this.txtApartamento.TabIndex = 17;
            // 
            // lblNomeDestinatario
            // 
            this.lblNomeDestinatario.AutoSize = true;
            this.lblNomeDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDestinatario.Location = new System.Drawing.Point(9, 30);
            this.lblNomeDestinatario.Name = "lblNomeDestinatario";
            this.lblNomeDestinatario.Size = new System.Drawing.Size(112, 13);
            this.lblNomeDestinatario.TabIndex = 0;
            this.lblNomeDestinatario.Text = "Nome do Destinatário:";
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartamento.Location = new System.Drawing.Point(9, 109);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(125, 13);
            this.lblApartamento.TabIndex = 6;
            this.lblApartamento.Text = "Número do Apartamento:";
            // 
            // cmbBloco
            // 
            this.cmbBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Location = new System.Drawing.Point(52, 79);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(59, 21);
            this.cmbBloco.TabIndex = 16;
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloco.Location = new System.Drawing.Point(9, 83);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 13);
            this.lblBloco.TabIndex = 5;
            this.lblBloco.Text = "Bloco:";
            // 
            // txtNomeDestinatario
            // 
            this.txtNomeDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDestinatario.Location = new System.Drawing.Point(12, 46);
            this.txtNomeDestinatario.Name = "txtNomeDestinatario";
            this.txtNomeDestinatario.Size = new System.Drawing.Size(209, 20);
            this.txtNomeDestinatario.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 410);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(247, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grpEncomenda
            // 
            this.grpEncomenda.Controls.Add(this.grpDescricao);
            this.grpEncomenda.Controls.Add(this.lblLocalArmazem);
            this.grpEncomenda.Controls.Add(this.mtxDataEntrega);
            this.grpEncomenda.Controls.Add(this.lblDataChegada);
            this.grpEncomenda.Controls.Add(this.cmbStatus);
            this.grpEncomenda.Controls.Add(this.lblStatus);
            this.grpEncomenda.Controls.Add(this.mtxDataChegada);
            this.grpEncomenda.Controls.Add(this.lblDataEntrega);
            this.grpEncomenda.Controls.Add(this.cmbLocalArmazem);
            this.grpEncomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEncomenda.Location = new System.Drawing.Point(6, 157);
            this.grpEncomenda.Name = "grpEncomenda";
            this.grpEncomenda.Size = new System.Drawing.Size(247, 247);
            this.grpEncomenda.TabIndex = 27;
            this.grpEncomenda.TabStop = false;
            this.grpEncomenda.Text = "Dados da Encomenda";
            // 
            // grpDescricao
            // 
            this.grpDescricao.Controls.Add(this.mtxDataDevolucao);
            this.grpDescricao.Controls.Add(this.cmbMotivo);
            this.grpDescricao.Controls.Add(this.lblMotivo);
            this.grpDescricao.Controls.Add(this.lblDataDevolucao);
            this.grpDescricao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescricao.Location = new System.Drawing.Point(3, 154);
            this.grpDescricao.Name = "grpDescricao";
            this.grpDescricao.Size = new System.Drawing.Size(241, 90);
            this.grpDescricao.TabIndex = 22;
            this.grpDescricao.TabStop = false;
            this.grpDescricao.Text = "Descrição";
            this.grpDescricao.Visible = false;
            // 
            // mtxDataDevolucao
            // 
            this.mtxDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDataDevolucao.Location = new System.Drawing.Point(114, 56);
            this.mtxDataDevolucao.Mask = "##/ ##/ ####";
            this.mtxDataDevolucao.Name = "mtxDataDevolucao";
            this.mtxDataDevolucao.Size = new System.Drawing.Size(71, 20);
            this.mtxDataDevolucao.TabIndex = 16;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(56, 26);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(162, 21);
            this.cmbMotivo.TabIndex = 15;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(8, 32);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 13;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolucao.Location = new System.Drawing.Point(8, 59);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(100, 13);
            this.lblDataDevolucao.TabIndex = 9;
            this.lblDataDevolucao.Text = "Data de Devolução";
            // 
            // lblLocalArmazem
            // 
            this.lblLocalArmazem.AutoSize = true;
            this.lblLocalArmazem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalArmazem.Location = new System.Drawing.Point(9, 35);
            this.lblLocalArmazem.Name = "lblLocalArmazem";
            this.lblLocalArmazem.Size = new System.Drawing.Size(130, 13);
            this.lblLocalArmazem.TabIndex = 11;
            this.lblLocalArmazem.Text = "Local de Armazenamento:";
            // 
            // mtxDataEntrega
            // 
            this.mtxDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDataEntrega.Location = new System.Drawing.Point(105, 121);
            this.mtxDataEntrega.Mask = "##/ ##/ ####";
            this.mtxDataEntrega.Name = "mtxDataEntrega";
            this.mtxDataEntrega.Size = new System.Drawing.Size(71, 20);
            this.mtxDataEntrega.TabIndex = 21;
            this.mtxDataEntrega.Visible = false;
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataChegada.Location = new System.Drawing.Point(11, 62);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(94, 13);
            this.lblDataChegada.TabIndex = 8;
            this.lblDataChegada.Text = "Data de Chegada:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(55, 94);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(166, 21);
            this.cmbStatus.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 97);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // mtxDataChegada
            // 
            this.mtxDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxDataChegada.Location = new System.Drawing.Point(111, 59);
            this.mtxDataChegada.Mask = "##/ ##/ ####";
            this.mtxDataChegada.Name = "mtxDataChegada";
            this.mtxDataChegada.Size = new System.Drawing.Size(71, 20);
            this.mtxDataChegada.TabIndex = 19;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrega.Location = new System.Drawing.Point(9, 124);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(88, 13);
            this.lblDataEntrega.TabIndex = 10;
            this.lblDataEntrega.Text = "Data de Entrega:";
            this.lblDataEntrega.Visible = false;
            // 
            // cmbLocalArmazem
            // 
            this.cmbLocalArmazem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalArmazem.FormattingEnabled = true;
            this.cmbLocalArmazem.Location = new System.Drawing.Point(145, 32);
            this.cmbLocalArmazem.Name = "cmbLocalArmazem";
            this.cmbLocalArmazem.Size = new System.Drawing.Size(76, 21);
            this.cmbLocalArmazem.TabIndex = 18;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.White;
            this.tpUpdate.Controls.Add(this.groupBox1);
            this.tpUpdate.Controls.Add(this.groupBox2);
            this.tpUpdate.Controls.Add(this.btnCancelar);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(259, 473);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Editar Encomenda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 141);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Destinatário";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do Destinatário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número do Apartamento:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bloco:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 247);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Encomenda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 90);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descrição";
            this.groupBox3.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(114, 56);
            this.maskedTextBox1.Mask = "##/ ##/ ####";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(56, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data de Devolução";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Local de Armazenamento:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(105, 121);
            this.maskedTextBox2.Mask = "##/ ##/ ####";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox2.TabIndex = 21;
            this.maskedTextBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data de Chegada:";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(55, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(166, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(111, 59);
            this.maskedTextBox3.Mask = "##/ ##/ ####";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox3.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data de Entrega:";
            this.label11.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(145, 32);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(76, 21);
            this.comboBox4.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNomeDestinatarioPesquisa
            // 
            this.txtNomeDestinatarioPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeDestinatarioPesquisa.BackColor = System.Drawing.Color.White;
            this.txtNomeDestinatarioPesquisa.Location = new System.Drawing.Point(285, 38);
            this.txtNomeDestinatarioPesquisa.Name = "txtNomeDestinatarioPesquisa";
            this.txtNomeDestinatarioPesquisa.Size = new System.Drawing.Size(503, 20);
            this.txtNomeDestinatarioPesquisa.TabIndex = 13;
            // 
            // cmbStatusPesquisa
            // 
            this.cmbStatusPesquisa.FormattingEnabled = true;
            this.cmbStatusPesquisa.Location = new System.Drawing.Point(323, 91);
            this.cmbStatusPesquisa.Name = "cmbStatusPesquisa";
            this.cmbStatusPesquisa.Size = new System.Drawing.Size(116, 21);
            this.cmbStatusPesquisa.TabIndex = 15;
            // 
            // lblStatusPesquisa
            // 
            this.lblStatusPesquisa.AutoSize = true;
            this.lblStatusPesquisa.Location = new System.Drawing.Point(282, 94);
            this.lblStatusPesquisa.Name = "lblStatusPesquisa";
            this.lblStatusPesquisa.Size = new System.Drawing.Size(40, 13);
            this.lblStatusPesquisa.TabIndex = 16;
            this.lblStatusPesquisa.Text = "Status:";
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Location = new System.Drawing.Point(323, 64);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(207, 21);
            this.cmbIntervalo.TabIndex = 17;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicio.Location = new System.Drawing.Point(536, 65);
            this.dtpDataInicio.MinimumSize = new System.Drawing.Size(226, 20);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(252, 20);
            this.dtpDataInicio.TabIndex = 18;
            // 
            // lblEntre
            // 
            this.lblEntre.AutoSize = true;
            this.lblEntre.Location = new System.Drawing.Point(282, 67);
            this.lblEntre.Name = "lblEntre";
            this.lblEntre.Size = new System.Drawing.Size(35, 13);
            this.lblEntre.TabIndex = 19;
            this.lblEntre.Text = "Entre:";
            // 
            // lblNomeDestinatarioPesquisa
            // 
            this.lblNomeDestinatarioPesquisa.AutoSize = true;
            this.lblNomeDestinatarioPesquisa.Location = new System.Drawing.Point(282, 22);
            this.lblNomeDestinatarioPesquisa.Name = "lblNomeDestinatarioPesquisa";
            this.lblNomeDestinatarioPesquisa.Size = new System.Drawing.Size(112, 13);
            this.lblNomeDestinatarioPesquisa.TabIndex = 20;
            this.lblNomeDestinatarioPesquisa.Text = "Nome do Destinatário:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(689, 89);
            this.btnPesquisar.MinimumSize = new System.Drawing.Size(74, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // pnlEncomendas
            // 
            this.pnlEncomendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEncomendas.BackColor = System.Drawing.Color.White;
            this.pnlEncomendas.Controls.Add(this.dgvEncomendas);
            this.pnlEncomendas.Location = new System.Drawing.Point(267, 129);
            this.pnlEncomendas.Name = "pnlEncomendas";
            this.pnlEncomendas.Size = new System.Drawing.Size(533, 370);
            this.pnlEncomendas.TabIndex = 12;
            // 
            // dgvEncomendas
            // 
            this.dgvEncomendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEncomendas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEncomendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomendas.Location = new System.Drawing.Point(18, 15);
            this.dgvEncomendas.Name = "dgvEncomendas";
            this.dgvEncomendas.Size = new System.Drawing.Size(503, 340);
            this.dgvEncomendas.TabIndex = 0;
            // 
            // FrmEncomendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblNomeDestinatarioPesquisa);
            this.Controls.Add(this.lblEntre);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.cmbIntervalo);
            this.Controls.Add(this.lblStatusPesquisa);
            this.Controls.Add(this.cmbStatusPesquisa);
            this.Controls.Add(this.txtNomeDestinatarioPesquisa);
            this.Controls.Add(this.pnlEncomendas);
            this.Controls.Add(this.tabCRUD);
            this.MinimumSize = new System.Drawing.Size(816, 0);
            this.Name = "FrmEncomendaView";
            this.Text = "Encomenda";
            this.tabCRUD.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            this.grpDestinatario.ResumeLayout(false);
            this.grpDestinatario.PerformLayout();
            this.grpEncomenda.ResumeLayout(false);
            this.grpEncomenda.PerformLayout();
            this.grpDescricao.ResumeLayout(false);
            this.grpDescricao.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlEncomendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCRUD;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TextBox txtNomeDestinatarioPesquisa;
        private System.Windows.Forms.ComboBox cmbStatusPesquisa;
        private System.Windows.Forms.Label lblStatusPesquisa;
        private System.Windows.Forms.ComboBox cmbIntervalo;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lblEntre;
        private System.Windows.Forms.Label lblNomeDestinatarioPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpDestinatario;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblNomeDestinatario;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.TextBox txtNomeDestinatario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpEncomenda;
        private System.Windows.Forms.GroupBox grpDescricao;
        private System.Windows.Forms.MaskedTextBox mtxDataDevolucao;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblLocalArmazem;
        private System.Windows.Forms.MaskedTextBox mtxDataEntrega;
        private System.Windows.Forms.Label lblDataChegada;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox mtxDataChegada;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.ComboBox cmbLocalArmazem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel pnlEncomendas;
        private System.Windows.Forms.DataGridView dgvEncomendas;
    }
}