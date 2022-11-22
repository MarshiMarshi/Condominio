
namespace Projeto_DS_Condominio.View
{
    partial class frmMainView
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
            this.tlpMudarView = new System.Windows.Forms.TableLayoutPanel();
            this.btnMorador = new System.Windows.Forms.Button();
            this.btnEncomenda = new System.Windows.Forms.Button();
            this.tlpMudarView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMudarView
            // 
            this.tlpMudarView.ColumnCount = 1;
            this.tlpMudarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMudarView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMudarView.Controls.Add(this.btnMorador, 0, 1);
            this.tlpMudarView.Controls.Add(this.btnEncomenda, 0, 0);
            this.tlpMudarView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpMudarView.Location = new System.Drawing.Point(0, 0);
            this.tlpMudarView.Name = "tlpMudarView";
            this.tlpMudarView.RowCount = 2;
            this.tlpMudarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMudarView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMudarView.Size = new System.Drawing.Size(91, 351);
            this.tlpMudarView.TabIndex = 3;
            // 
            // btnMorador
            // 
            this.btnMorador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMorador.BackgroundImage = global::Projeto_DS_Condominio.Properties.Resources.user_solid;
            this.btnMorador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMorador.Location = new System.Drawing.Point(6, 178);
            this.btnMorador.Name = "btnMorador";
            this.btnMorador.Size = new System.Drawing.Size(79, 170);
            this.btnMorador.TabIndex = 2;
            this.btnMorador.UseVisualStyleBackColor = true;
            // 
            // btnEncomenda
            // 
            this.btnEncomenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEncomenda.BackgroundImage = global::Projeto_DS_Condominio.Properties.Resources.box_solid;
            this.btnEncomenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncomenda.Location = new System.Drawing.Point(6, 3);
            this.btnEncomenda.Name = "btnEncomenda";
            this.btnEncomenda.Size = new System.Drawing.Size(79, 169);
            this.btnEncomenda.TabIndex = 1;
            this.btnEncomenda.UseVisualStyleBackColor = true;
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.tlpMudarView);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(16, 390);
            this.Name = "frmMainView";
            this.Text = "MainView";
            this.tlpMudarView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMorador;
        private System.Windows.Forms.Button btnEncomenda;
        private System.Windows.Forms.TableLayoutPanel tlpMudarView;
    }
}