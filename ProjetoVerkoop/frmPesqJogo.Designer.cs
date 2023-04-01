namespace ProjetoVerkoop
{
    partial class frmPesqJogo
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRestricao = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.nudRestricao = new System.Windows.Forms.NumericUpDown();
            this.nudPreco = new System.Windows.Forms.NumericUpDown();
            this.cboNome = new System.Windows.Forms.CheckBox();
            this.cboRestricao = new System.Windows.Forms.CheckBox();
            this.cboPreco = new System.Windows.Forms.CheckBox();
            this.btnSelecFiltros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(20, 144);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 28);
            this.txtNome.TabIndex = 1;
            // 
            // lblRestricao
            // 
            this.lblRestricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblRestricao.Location = new System.Drawing.Point(20, 240);
            this.lblRestricao.Name = "lblRestricao";
            this.lblRestricao.RowHeadersWidth = 62;
            this.lblRestricao.Size = new System.Drawing.Size(325, 173);
            this.lblRestricao.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(20, 419);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(160, 32);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // nudRestricao
            // 
            this.nudRestricao.Enabled = false;
            this.nudRestricao.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRestricao.Location = new System.Drawing.Point(185, 142);
            this.nudRestricao.Margin = new System.Windows.Forms.Padding(2);
            this.nudRestricao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRestricao.Name = "nudRestricao";
            this.nudRestricao.Size = new System.Drawing.Size(160, 28);
            this.nudRestricao.TabIndex = 5;
            this.nudRestricao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPreco
            // 
            this.nudPreco.DecimalPlaces = 2;
            this.nudPreco.Enabled = false;
            this.nudPreco.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPreco.Location = new System.Drawing.Point(20, 207);
            this.nudPreco.Margin = new System.Windows.Forms.Padding(2);
            this.nudPreco.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPreco.Name = "nudPreco";
            this.nudPreco.Size = new System.Drawing.Size(160, 28);
            this.nudPreco.TabIndex = 7;
            // 
            // cboNome
            // 
            this.cboNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.cboNome.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.cboNome.ForeColor = System.Drawing.Color.White;
            this.cboNome.Location = new System.Drawing.Point(20, 114);
            this.cboNome.Margin = new System.Windows.Forms.Padding(2);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(160, 30);
            this.cboNome.TabIndex = 8;
            this.cboNome.Text = "Nome";
            this.cboNome.UseVisualStyleBackColor = false;
            // 
            // cboRestricao
            // 
            this.cboRestricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.cboRestricao.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.cboRestricao.ForeColor = System.Drawing.Color.White;
            this.cboRestricao.Location = new System.Drawing.Point(185, 114);
            this.cboRestricao.Margin = new System.Windows.Forms.Padding(2);
            this.cboRestricao.Name = "cboRestricao";
            this.cboRestricao.Size = new System.Drawing.Size(160, 30);
            this.cboRestricao.TabIndex = 9;
            this.cboRestricao.Text = "Restrição";
            this.cboRestricao.UseVisualStyleBackColor = false;
            // 
            // cboPreco
            // 
            this.cboPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.cboPreco.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.cboPreco.ForeColor = System.Drawing.Color.White;
            this.cboPreco.Location = new System.Drawing.Point(20, 177);
            this.cboPreco.Margin = new System.Windows.Forms.Padding(2);
            this.cboPreco.Name = "cboPreco";
            this.cboPreco.Size = new System.Drawing.Size(160, 30);
            this.cboPreco.TabIndex = 10;
            this.cboPreco.Text = "Preço";
            this.cboPreco.UseVisualStyleBackColor = false;
            // 
            // btnSelecFiltros
            // 
            this.btnSelecFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnSelecFiltros.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.btnSelecFiltros.ForeColor = System.Drawing.Color.White;
            this.btnSelecFiltros.Location = new System.Drawing.Point(184, 174);
            this.btnSelecFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecFiltros.Name = "btnSelecFiltros";
            this.btnSelecFiltros.Size = new System.Drawing.Size(160, 61);
            this.btnSelecFiltros.TabIndex = 11;
            this.btnSelecFiltros.Text = "Selecionar Filtros";
            this.btnSelecFiltros.UseVisualStyleBackColor = false;
            this.btnSelecFiltros.Click += new System.EventHandler(this.btnSelecFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.btnSelecFiltros);
            this.groupBox1.Controls.Add(this.cboPreco);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.cboRestricao);
            this.groupBox1.Controls.Add(this.nudPreco);
            this.groupBox1.Controls.Add(this.cboNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.nudRestricao);
            this.groupBox1.Controls.Add(this.lblRestricao);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 457);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PESQUISA DE JOGOS";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnLimpar.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(184, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 31);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProjetoVerkoop.Properties.Resources._7;
            this.picLogo.Location = new System.Drawing.Point(271, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(97, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // frmPesqJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPesqJogo";
            this.Text = "Pesquisa de Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.lblRestricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView lblRestricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.NumericUpDown nudRestricao;
        private System.Windows.Forms.NumericUpDown nudPreco;
        private System.Windows.Forms.CheckBox cboNome;
        private System.Windows.Forms.CheckBox cboRestricao;
        private System.Windows.Forms.CheckBox cboPreco;
        private System.Windows.Forms.Button btnSelecFiltros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLimpar;
    }
}