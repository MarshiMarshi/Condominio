
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNomeDestinatarioPesquisa = new System.Windows.Forms.TextBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpMorador = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApartamento = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApartamento = new System.Windows.Forms.Label();
            this.cmbBloco = new System.Windows.Forms.ComboBox();
            this.lblBloco = new System.Windows.Forms.Label();
            this.txtNomeDestinatario = new System.Windows.Forms.TextBox();
            this.tpUpdate.SuspendLayout();
            this.tabCRUD.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.grpMorador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(282, 41);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesquisa.TabIndex = 30;
            this.lblNomePesquisa.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 407);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNomeDestinatarioPesquisa
            // 
            this.txtNomeDestinatarioPesquisa.BackColor = System.Drawing.Color.White;
            this.txtNomeDestinatarioPesquisa.Location = new System.Drawing.Point(323, 38);
            this.txtNomeDestinatarioPesquisa.Name = "txtNomeDestinatarioPesquisa";
            this.txtNomeDestinatarioPesquisa.Size = new System.Drawing.Size(465, 20);
            this.txtNomeDestinatarioPesquisa.TabIndex = 24;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.Color.White;
            this.tpUpdate.Controls.Add(this.btnCancelar);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(259, 424);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Editar Morador";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(689, 89);
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
            this.grpMorador.Controls.Add(this.maskedTextBox2);
            this.grpMorador.Controls.Add(this.maskedTextBox1);
            this.grpMorador.Controls.Add(this.label1);
            this.grpMorador.Controls.Add(this.label2);
            this.grpMorador.Controls.Add(this.txtApartamento);
            this.grpMorador.Controls.Add(this.lblNome);
            this.grpMorador.Controls.Add(this.lblApartamento);
            this.grpMorador.Controls.Add(this.cmbBloco);
            this.grpMorador.Controls.Add(this.lblBloco);
            this.grpMorador.Controls.Add(this.txtNomeDestinatario);
            this.grpMorador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMorador.Location = new System.Drawing.Point(6, 6);
            this.grpMorador.Name = "grpMorador";
            this.grpMorador.Size = new System.Drawing.Size(247, 156);
            this.grpMorador.TabIndex = 27;
            this.grpMorador.TabStop = false;
            this.grpMorador.Text = "Dados do Morador";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox2.Location = new System.Drawing.Point(60, 78);
            this.maskedTextBox2.Mask = "000.000.000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBox2.TabIndex = 27;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(60, 51);
            this.maskedTextBox1.Mask = "00.000.000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBox1.TabIndex = 26;
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
            this.cmbBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloco.FormattingEnabled = true;
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
            // txtNomeDestinatario
            // 
            this.txtNomeDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDestinatario.Location = new System.Drawing.Point(60, 24);
            this.txtNomeDestinatario.Name = "txtNomeDestinatario";
            this.txtNomeDestinatario.Size = new System.Drawing.Size(169, 20);
            this.txtNomeDestinatario.TabIndex = 21;
            // 
            // frmMoradorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomePesquisa);
            this.Controls.Add(this.txtNomeDestinatarioPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tabCRUD);
            this.Name = "frmMoradorView";
            this.Text = "MoradorView";
            this.tpUpdate.ResumeLayout(false);
            this.tabCRUD.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            this.grpMorador.ResumeLayout(false);
            this.grpMorador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNomeDestinatarioPesquisa;
        private System.Windows.Forms.TabPage tpUpdate;
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
        private System.Windows.Forms.TextBox txtNomeDestinatario;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}