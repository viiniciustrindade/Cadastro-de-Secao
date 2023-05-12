namespace CadastrodeSecao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txtDescSecao = new System.Windows.Forms.TextBox();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodSecao,
            this.colDescSecao});
            this.dadosGrid.Location = new System.Drawing.Point(12, 103);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(567, 207);
            this.dadosGrid.TabIndex = 35;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(494, 69);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(85, 22);
            this.btn_Excluir.TabIndex = 34;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click_1);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(494, 47);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(85, 22);
            this.btn_Salvar.TabIndex = 33;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click_1);
            // 
            // txtDescSecao
            // 
            this.txtDescSecao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescSecao.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescSecao.Location = new System.Drawing.Point(110, 47);
            this.txtDescSecao.Multiline = true;
            this.txtDescSecao.Name = "txtDescSecao";
            this.txtDescSecao.Size = new System.Drawing.Size(378, 44);
            this.txtDescSecao.TabIndex = 32;
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Location = new System.Drawing.Point(110, 22);
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(65, 20);
            this.txtCodSecao.TabIndex = 31;
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(12, 47);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(92, 15);
            this.labelNomeAutor.TabIndex = 30;
            this.labelNomeAutor.Text = "Descrição Seção";
            // 
            // colCodSecao
            // 
            this.colCodSecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodSecao.FillWeight = 152.2843F;
            this.colCodSecao.HeaderText = "Codigo";
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            this.colCodSecao.Width = 65;
            // 
            // colDescSecao
            // 
            this.colDescSecao.FillWeight = 73.85786F;
            this.colDescSecao.HeaderText = "Descrição";
            this.colDescSecao.Name = "colDescSecao";
            this.colDescSecao.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(591, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txtDescSecao);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.labelNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Seção";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txtDescSecao;
        private System.Windows.Forms.TextBox txtCodSecao;
        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescSecao;
    }
}

