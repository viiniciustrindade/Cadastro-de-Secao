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
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txtDescSecao = new System.Windows.Forms.TextBox();
            this.txtCodSecao = new System.Windows.Forms.TextBox();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.asteriscoAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
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
            this.dadosGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid.Location = new System.Drawing.Point(16, 100);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(789, 335);
            this.dadosGrid.TabIndex = 35;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodSecao.FillWeight = 152.2843F;
            this.colCodSecao.HeaderText = "Codigo";
            this.colCodSecao.MinimumWidth = 6;
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            this.colCodSecao.Width = 80;
            // 
            // colDescSecao
            // 
            this.colDescSecao.FillWeight = 73.85786F;
            this.colDescSecao.HeaderText = "Descrição";
            this.colDescSecao.MinimumWidth = 6;
            this.colDescSecao.Name = "colDescSecao";
            this.colDescSecao.ReadOnly = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(691, 65);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 27);
            this.btn_Excluir.TabIndex = 34;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click_1);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(691, 39);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(113, 27);
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
            this.txtDescSecao.Location = new System.Drawing.Point(147, 39);
            this.txtDescSecao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescSecao.Multiline = true;
            this.txtDescSecao.Name = "txtDescSecao";
            this.txtDescSecao.Size = new System.Drawing.Size(524, 53);
            this.txtDescSecao.TabIndex = 32;
            this.txtDescSecao.TextChanged += new System.EventHandler(this.txtDescSecao_TextChanged);
            // 
            // txtCodSecao
            // 
            this.txtCodSecao.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodSecao.Enabled = false;
            this.txtCodSecao.Location = new System.Drawing.Point(147, 9);
            this.txtCodSecao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodSecao.Name = "txtCodSecao";
            this.txtCodSecao.Size = new System.Drawing.Size(85, 22);
            this.txtCodSecao.TabIndex = 31;
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(21, 39);
            this.labelNomeAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(118, 20);
            this.labelNomeAutor.TabIndex = 30;
            this.labelNomeAutor.Text = "Descrição Seção";
            // 
            // asteriscoAlert
            // 
            this.asteriscoAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asteriscoAlert.AutoSize = true;
            this.asteriscoAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asteriscoAlert.ForeColor = System.Drawing.Color.Red;
            this.asteriscoAlert.Location = new System.Drawing.Point(674, 39);
            this.asteriscoAlert.Name = "asteriscoAlert";
            this.asteriscoAlert.Size = new System.Drawing.Size(12, 16);
            this.asteriscoAlert.TabIndex = 37;
            this.asteriscoAlert.Text = "*";
            this.asteriscoAlert.MouseHover += new System.EventHandler(this.asteriscoAlert_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.asteriscoAlert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txtDescSecao);
            this.Controls.Add(this.txtCodSecao);
            this.Controls.Add(this.labelNomeAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label asteriscoAlert;
    }
}

