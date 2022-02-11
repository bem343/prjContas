namespace prjContas
{
    partial class frmPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lblNome = new System.Windows.Forms.Label();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.gvPagamentos = new System.Windows.Forms.DataGridView();
            this.lblData = new System.Windows.Forms.Label();
            this.btnComprovante = new System.Windows.Forms.Button();
            this.btnBoleto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(788, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(13, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "_";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(12, 59);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(136, 264);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(12, 332);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(136, 33);
            this.btnPagamento.TabIndex = 1;
            this.btnPagamento.Text = "Novo pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            // 
            // gvPagamentos
            // 
            this.gvPagamentos.AllowUserToAddRows = false;
            this.gvPagamentos.AllowUserToDeleteRows = false;
            this.gvPagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPagamentos.Location = new System.Drawing.Point(154, 59);
            this.gvPagamentos.Name = "gvPagamentos";
            this.gvPagamentos.ReadOnly = true;
            this.gvPagamentos.RowHeadersVisible = false;
            this.gvPagamentos.Size = new System.Drawing.Size(622, 264);
            this.gvPagamentos.TabIndex = 4;
            this.gvPagamentos.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(668, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(108, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Pagamentos de 2022";
            // 
            // btnComprovante
            // 
            this.btnComprovante.Location = new System.Drawing.Point(640, 332);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(136, 33);
            this.btnComprovante.TabIndex = 3;
            this.btnComprovante.Text = "Comprovante";
            this.btnComprovante.UseVisualStyleBackColor = true;
            // 
            // btnBoleto
            // 
            this.btnBoleto.Location = new System.Drawing.Point(498, 332);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(136, 33);
            this.btnBoleto.TabIndex = 2;
            this.btnBoleto.Text = "Boleto";
            this.btnBoleto.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 375);
            this.Controls.Add(this.btnBoleto);
            this.Controls.Add(this.btnComprovante);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.gvPagamentos);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de contas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.DataGridView gvPagamentos;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnComprovante;
        private System.Windows.Forms.Button btnBoleto;
    }
}

