
namespace Projeto_DS_Condominio.View
{
    partial class frmMoradorView
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
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpMorador = new System.Windows.Forms.GroupBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.lblBloco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.grpMoradorEdicao = new System.Windows.Forms.GroupBox();
            this.mtxCPFEdicao = new System.Windows.Forms.MaskedTextBox();
            this.mtxRGEdicao = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFEdicao = new System.Windows.Forms.Label();
            this.lblRGEdicao = new System.Windows.Forms.Label();
            this.txtApartamentoEdicao = new System.Windows.Forms.TextBox();
            this.lblNomeEdicao = new System.Windows.Forms.Label();
            this.lblApartamentoEdicao = new System.Windows.Forms.Label();
            this.cmbBlocoEdicao = new System.Windows.Forms.ComboBox();
            this.lblBlocoEdicao = new System.Windows.Forms.Label();
            this.txtNomeEdicao = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblStatusPesquisa = new System.Windows.Forms.Label();
            this.pnlEncomendas = new System.Windows.Forms.Panel();
            this.dgvMoradores = new System.Windows.Forms.DataGridView();
            this.cmbBlocoPesquisa = new System.Windows.Forms.ComboBox();
            this.txtApartamentoPesquisa = new System.Windows.Forms.TextBox();
            this.lblApartamentoPesquisa = new System.Windows.Forms.Label();
            this.mtxRGPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.lblRGPesquisa = new System.Windows.Forms.Label();
            this.mtxCPFPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFPesquisa = new System.Windows.Forms.Label();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.tabCRUD.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.grpMorador.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.grpMoradorEdicao.SuspendLayout();
            this.pnlEncomendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(6, 20);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(38, 13);
            this.lblNomePesquisa.TabIndex = 30;
            this.lblNomePesquisa.Text = "Nome:";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePesquisa.BackColor = System.Drawing.Color.White;
            this.txtNomePesquisa.Location = new System.Drawing.Point(47, 17);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(475, 20);
            this.txtNomePesquisa.TabIndex = 24;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(423, 68);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(99, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.tpCreate);
            this.tabCRUD.Controls.Add(this.tpUpdate);
            this.tabCRUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabCRUD.Location = new System.Drawing.Point(0, 0);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.SelectedIndex = 0;
            this.tabCRUD.Size = new System.Drawing.Size(267, 450);
            this.tabCRUD.TabIndex = 22;
            // 
            // tpCreate
            // 
            this.tpCreate.BackColor = System.Drawing.Color.White;
            this.tpCreate.Controls.Add(this.btnLimpar);
            this.tpCreate.Controls.Add(this.btnSalvar);
            this.tpCreate.Controls.Add(this.grpMorador);
            this.tpCreate.Location = new System.Drawing.Point(4, 22);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreate.Size = new System.Drawing.Size(259, 424);
            this.tpCreate.TabIndex = 0;
            this.tpCreate.Text = "Criar Morador";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(6, 197);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(247, 23);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar Caixas de Texto";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(247, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grpMorador
            // 
            this.grpMorador.Controls.Add(this.mtxCPF);
            this.grpMorador.Controls.Add(this.mtxRG);
            this.grpMorador.Controls.Add(this.label1);
            this.grpMorador.Controls.Add(this.label2);
            this.grpMorador.Controls.Add(this.txtApartamento);
            this.grpMorador.Controls.Add(this.lblNome);
            this.grpMorador.Controls.Add(this.lblApartamento);
            this.grpMorador.Controls.Add(this.cmbBloco);
            this.grpMorador.Controls.Add(this.lblBloco);
            this.grpMorador.Controls.Add(this.txtNome);
            this.grpMorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMorador.Location = new System.Drawing.Point(6, 6);
            this.grpMorador.Name = "grpMorador";
            this.grpMorador.Size = new System.Drawing.Size(247, 156);
            this.grpMorador.TabIndex = 27;
            this.grpMorador.TabStop = false;
            this.grpMorador.Text = "Dados do Morador";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxCPF.Location = new System.Drawing.Point(60, 78);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(98, 20);
            this.mtxCPF.TabIndex = 27;
            // 
            // mtxRG
            // 
            this.mtxRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxRG.Location = new System.Drawing.Point(60, 51);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(82, 20);
            this.mtxRG.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "RG:";
            // 
            // txtApartamento
            // 
            this.txtApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamento.Location = new System.Drawing.Point(148, 129);
            this.txtApartamento.Name = "txtApartamento";
            this.txtApartamento.Size = new System.Drawing.Size(81, 20);
            this.txtApartamento.TabIndex = 23;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(17, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // lblApartamento
            // 
            this.lblApartamento.AutoSize = true;
            this.lblApartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartamento.Location = new System.Drawing.Point(17, 132);
            this.lblApartamento.Name = "lblApartamento";
            this.lblApartamento.Size = new System.Drawing.Size(125, 13);
            this.lblApartamento.TabIndex = 20;
            this.lblApartamento.Text = "Número do Apartamento:";
            // 
            // cmbBloco
            // 
            this.cmbBloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloco.FormattingEnabled = true;
            this.cmbBloco.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbBloco.Location = new System.Drawing.Point(60, 104);
            this.cmbBloco.Name = "cmbBloco";
            this.cmbBloco.Size = new System.Drawing.Size(59, 21);
            this.cmbBloco.TabIndex = 22;
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloco.Location = new System.Drawing.Point(17, 108);
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(37, 13);
            this.lblBloco.TabIndex = 19;
            this.lblBloco.Text = "Bloco:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(60, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 20);
            this.txtNome.TabIndex = 21;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.White;
            this.tpUpdate.Controls.Add(this.grpMoradorEdicao);
            this.tpUpdate.Controls.Add(this.btnEditar);
            this.tpUpdate.Controls.Add(this.btnCancelar);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(259, 424);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Editar Morador";
            // 
            // grpMoradorEdicao
            // 
            this.grpMoradorEdicao.Controls.Add(this.mtxCPFEdicao);
            this.grpMoradorEdicao.Controls.Add(this.mtxRGEdicao);
            this.grpMoradorEdicao.Controls.Add(this.lblCPFEdicao);
            this.grpMoradorEdicao.Controls.Add(this.lblRGEdicao);
            this.grpMoradorEdicao.Controls.Add(this.txtApartamentoEdicao);
            this.grpMoradorEdicao.Controls.Add(this.lblNomeEdicao);
            this.grpMoradorEdicao.Controls.Add(this.lblApartamentoEdicao);
            this.grpMoradorEdicao.Controls.Add(this.cmbBlocoEdicao);
            this.grpMoradorEdicao.Controls.Add(this.lblBlocoEdicao);
            this.grpMoradorEdicao.Controls.Add(this.txtNomeEdicao);
            this.grpMoradorEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoradorEdicao.Location = new System.Drawing.Point(6, 6);
            this.grpMoradorEdicao.Name = "grpMoradorEdicao";
            this.grpMoradorEdicao.Size = new System.Drawing.Size(247, 156);
            this.grpMoradorEdicao.TabIndex = 34;
            this.grpMoradorEdicao.TabStop = false;
            this.grpMoradorEdicao.Text = "Dados do Morador";
            // 
            // mtxCPFEdicao
            // 
            this.mtxCPFEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxCPFEdicao.Location = new System.Drawing.Point(60, 78);
            this.mtxCPFEdicao.Mask = "000.000.000-00";
            this.mtxCPFEdicao.Name = "mtxCPFEdicao";
            this.mtxCPFEdicao.Size = new System.Drawing.Size(98, 20);
            this.mtxCPFEdicao.TabIndex = 27;
            // 
            // mtxRGEdicao
            // 
            this.mtxRGEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxRGEdicao.Location = new System.Drawing.Point(60, 51);
            this.mtxRGEdicao.Mask = "00.000.000-0";
            this.mtxRGEdicao.Name = "mtxRGEdicao";
            this.mtxRGEdicao.Size = new System.Drawing.Size(82, 20);
            this.mtxRGEdicao.TabIndex = 26;
            // 
            // lblCPFEdicao
            // 
            this.lblCPFEdicao.AutoSize = true;
            this.lblCPFEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFEdicao.Location = new System.Drawing.Point(17, 81);
            this.lblCPFEdicao.Name = "lblCPFEdicao";
            this.lblCPFEdicao.Size = new System.Drawing.Size(30, 13);
            this.lblCPFEdicao.TabIndex = 25;
            this.lblCPFEdicao.Text = "CPF:";
            // 
            // lblRGEdicao
            // 
            this.lblRGEdicao.AutoSize = true;
            this.lblRGEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGEdicao.Location = new System.Drawing.Point(17, 54);
            this.lblRGEdicao.Name = "lblRGEdicao";
            this.lblRGEdicao.Size = new System.Drawing.Size(26, 13);
            this.lblRGEdicao.TabIndex = 24;
            this.lblRGEdicao.Text = "RG:";
            // 
            // txtApartamentoEdicao
            // 
            this.txtApartamentoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamentoEdicao.Location = new System.Drawing.Point(148, 129);
            this.txtApartamentoEdicao.Name = "txtApartamentoEdicao";
            this.txtApartamentoEdicao.Size = new System.Drawing.Size(81, 20);
            this.txtApartamentoEdicao.TabIndex = 23;
            // 
            // lblNomeEdicao
            // 
            this.lblNomeEdicao.AutoSize = true;
            this.lblNomeEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdicao.Location = new System.Drawing.Point(17, 27);
            this.lblNomeEdicao.Name = "lblNomeEdicao";
            this.lblNomeEdicao.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEdicao.TabIndex = 18;
            this.lblNomeEdicao.Text = "Nome:";
            // 
            // lblApartamentoEdicao
            // 
            this.lblApartamentoEdicao.AutoSize = true;
            this.lblApartamentoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartamentoEdicao.Location = new System.Drawing.Point(17, 132);
            this.lblApartamentoEdicao.Name = "lblApartamentoEdicao";
            this.lblApartamentoEdicao.Size = new System.Drawing.Size(125, 13);
            this.lblApartamentoEdicao.TabIndex = 20;
            this.lblApartamentoEdicao.Text = "Número do Apartamento:";
            // 
            // cmbBlocoEdicao
            // 
            this.cmbBlocoEdicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlocoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlocoEdicao.FormattingEnabled = true;
            this.cmbBlocoEdicao.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbBlocoEdicao.Location = new System.Drawing.Point(60, 104);
            this.cmbBlocoEdicao.Name = "cmbBlocoEdicao";
            this.cmbBlocoEdicao.Size = new System.Drawing.Size(59, 21);
            this.cmbBlocoEdicao.TabIndex = 22;
            // 
            // lblBlocoEdicao
            // 
            this.lblBlocoEdicao.AutoSize = true;
            this.lblBlocoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlocoEdicao.Location = new System.Drawing.Point(17, 108);
            this.lblBlocoEdicao.Name = "lblBlocoEdicao";
            this.lblBlocoEdicao.Size = new System.Drawing.Size(37, 13);
            this.lblBlocoEdicao.TabIndex = 19;
            this.lblBlocoEdicao.Text = "Bloco:";
            // 
            // txtNomeEdicao
            // 
            this.txtNomeEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEdicao.Location = new System.Drawing.Point(60, 24);
            this.txtNomeEdicao.Name = "txtNomeEdicao";
            this.txtNomeEdicao.Size = new System.Drawing.Size(169, 20);
            this.txtNomeEdicao.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(247, 23);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(247, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblStatusPesquisa
            // 
            this.lblStatusPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusPesquisa.AutoSize = true;
            this.lblStatusPesquisa.Location = new System.Drawing.Point(6, 73);
            this.lblStatusPesquisa.Name = "lblStatusPesquisa";
            this.lblStatusPesquisa.Size = new System.Drawing.Size(37, 13);
            this.lblStatusPesquisa.TabIndex = 34;
            this.lblStatusPesquisa.Text = "Bloco:";
            // 
            // pnlEncomendas
            // 
            this.pnlEncomendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEncomendas.BackColor = System.Drawing.Color.White;
            this.pnlEncomendas.Controls.Add(this.dgvMoradores);
            this.pnlEncomendas.Location = new System.Drawing.Point(267, 136);
            this.pnlEncomendas.Name = "pnlEncomendas";
            this.pnlEncomendas.Size = new System.Drawing.Size(543, 314);
            this.pnlEncomendas.TabIndex = 31;
            // 
            // dgvMoradores
            // 
            this.dgvMoradores.AllowUserToAddRows = false;
            this.dgvMoradores.AllowUserToDeleteRows = false;
            this.dgvMoradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMoradores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMoradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoradores.Location = new System.Drawing.Point(15, 21);
            this.dgvMoradores.Name = "dgvMoradores";
            this.dgvMoradores.ReadOnly = true;
            this.dgvMoradores.Size = new System.Drawing.Size(513, 273);
            this.dgvMoradores.TabIndex = 0;
            // 
            // cmbBlocoPesquisa
            // 
            this.cmbBlocoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlocoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlocoPesquisa.FormattingEnabled = true;
            this.cmbBlocoPesquisa.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbBlocoPesquisa.Location = new System.Drawing.Point(47, 70);
            this.cmbBlocoPesquisa.Name = "cmbBlocoPesquisa";
            this.cmbBlocoPesquisa.Size = new System.Drawing.Size(82, 21);
            this.cmbBlocoPesquisa.TabIndex = 38;
            // 
            // txtApartamentoPesquisa
            // 
            this.txtApartamentoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApartamentoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartamentoPesquisa.Location = new System.Drawing.Point(307, 71);
            this.txtApartamentoPesquisa.Name = "txtApartamentoPesquisa";
            this.txtApartamentoPesquisa.Size = new System.Drawing.Size(98, 20);
            this.txtApartamentoPesquisa.TabIndex = 39;
            // 
            // lblApartamentoPesquisa
            // 
            this.lblApartamentoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApartamentoPesquisa.AutoSize = true;
            this.lblApartamentoPesquisa.Location = new System.Drawing.Point(231, 74);
            this.lblApartamentoPesquisa.Name = "lblApartamentoPesquisa";
            this.lblApartamentoPesquisa.Size = new System.Drawing.Size(70, 13);
            this.lblApartamentoPesquisa.TabIndex = 40;
            this.lblApartamentoPesquisa.Text = "Apartamento:";
            // 
            // mtxRGPesquisa
            // 
            this.mtxRGPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxRGPesquisa.Location = new System.Drawing.Point(47, 44);
            this.mtxRGPesquisa.Mask = "00.000.000-0";
            this.mtxRGPesquisa.Name = "mtxRGPesquisa";
            this.mtxRGPesquisa.Size = new System.Drawing.Size(82, 20);
            this.mtxRGPesquisa.TabIndex = 42;
            // 
            // lblRGPesquisa
            // 
            this.lblRGPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRGPesquisa.AutoSize = true;
            this.lblRGPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGPesquisa.Location = new System.Drawing.Point(6, 47);
            this.lblRGPesquisa.Name = "lblRGPesquisa";
            this.lblRGPesquisa.Size = new System.Drawing.Size(26, 13);
            this.lblRGPesquisa.TabIndex = 41;
            this.lblRGPesquisa.Text = "RG:";
            // 
            // mtxCPFPesquisa
            // 
            this.mtxCPFPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxCPFPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.mtxCPFPesquisa.Location = new System.Drawing.Point(307, 45);
            this.mtxCPFPesquisa.Mask = "000.000.000-00";
            this.mtxCPFPesquisa.Name = "mtxCPFPesquisa";
            this.mtxCPFPesquisa.Size = new System.Drawing.Size(98, 20);
            this.mtxCPFPesquisa.TabIndex = 44;
            // 
            // lblCPFPesquisa
            // 
            this.lblCPFPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPFPesquisa.AutoSize = true;
            this.lblCPFPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFPesquisa.Location = new System.Drawing.Point(231, 48);
            this.lblCPFPesquisa.Name = "lblCPFPesquisa";
            this.lblCPFPesquisa.Size = new System.Drawing.Size(30, 13);
            this.lblCPFPesquisa.TabIndex = 43;
            this.lblCPFPesquisa.Text = "CPF:";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPesquisa.Controls.Add(this.mtxCPFPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtNomePesquisa);
            this.pnlPesquisa.Controls.Add(this.lblCPFPesquisa);
            this.pnlPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlPesquisa.Controls.Add(this.mtxRGPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblNomePesquisa);
            this.pnlPesquisa.Controls.Add(this.lblRGPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblStatusPesquisa);
            this.pnlPesquisa.Controls.Add(this.lblApartamentoPesquisa);
            this.pnlPesquisa.Controls.Add(this.cmbBlocoPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtApartamentoPesquisa);
            this.pnlPesquisa.Location = new System.Drawing.Point(273, 22);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(525, 100);
            this.pnlPesquisa.TabIndex = 45;
            // 
            // frmMoradorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.pnlEncomendas);
            this.Controls.Add(this.tabCRUD);
            this.Controls.Add(this.pnlPesquisa);
            this.MinimumSize = new System.Drawing.Size(730, 297);
            this.Name = "frmMoradorView";
            this.Text = "MoradorView";
            this.tabCRUD.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            this.grpMorador.ResumeLayout(false);
            this.grpMorador.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.grpMoradorEdicao.ResumeLayout(false);
            this.grpMoradorEdicao.PerformLayout();
            this.pnlEncomendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoradores)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabControl tabCRUD;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpMorador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApartamento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApartamento;
        private System.Windows.Forms.ComboBox cmbBloco;
        private System.Windows.Forms.Label lblBloco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblStatusPesquisa;
        private System.Windows.Forms.Panel pnlEncomendas;
        private System.Windows.Forms.ComboBox cmbBlocoPesquisa;
        private System.Windows.Forms.TextBox txtApartamentoPesquisa;
        private System.Windows.Forms.Label lblApartamentoPesquisa;
        private System.Windows.Forms.MaskedTextBox mtxRGPesquisa;
        private System.Windows.Forms.Label lblRGPesquisa;
        private System.Windows.Forms.MaskedTextBox mtxCPFPesquisa;
        private System.Windows.Forms.Label lblCPFPesquisa;
        private System.Windows.Forms.GroupBox grpMoradorEdicao;
        private System.Windows.Forms.MaskedTextBox mtxCPFEdicao;
        private System.Windows.Forms.MaskedTextBox mtxRGEdicao;
        private System.Windows.Forms.Label lblCPFEdicao;
        private System.Windows.Forms.Label lblRGEdicao;
        private System.Windows.Forms.TextBox txtApartamentoEdicao;
        private System.Windows.Forms.Label lblNomeEdicao;
        private System.Windows.Forms.Label lblApartamentoEdicao;
        private System.Windows.Forms.ComboBox cmbBlocoEdicao;
        private System.Windows.Forms.Label lblBlocoEdicao;
        private System.Windows.Forms.TextBox txtNomeEdicao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.DataGridView dgvMoradores;
    }
}