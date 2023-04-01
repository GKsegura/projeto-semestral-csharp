namespace ProjetoVerkoop
{
    partial class frmExcluiJogo
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
            this.lblRestricao = new System.Windows.Forms.DataGridView();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnExluir = new System.Windows.Forms.Button();
            this.txtCodJogo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblRestricao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestricao
            // 
            this.lblRestricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblRestricao.Location = new System.Drawing.Point(19, 104);
            this.lblRestricao.Name = "lblRestricao";
            this.lblRestricao.RowHeadersWidth = 62;
            this.lblRestricao.Size = new System.Drawing.Size(333, 141);
            this.lblRestricao.TabIndex = 13;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.lblCod.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.White;
            this.lblCod.Location = new System.Drawing.Point(19, 248);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(302, 34);
            this.lblCod.TabIndex = 16;
            this.lblCod.Text = "Código do jogo a ser exclúido:";
            this.lblCod.Click += new System.EventHandler(this.lblCod_Click);
            // 
            // btnExluir
            // 
            this.btnExluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnExluir.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExluir.ForeColor = System.Drawing.Color.White;
            this.btnExluir.Location = new System.Drawing.Point(115, 342);
            this.btnExluir.Name = "btnExluir";
            this.btnExluir.Size = new System.Drawing.Size(160, 43);
            this.btnExluir.TabIndex = 17;
            this.btnExluir.Text = "Excluir";
            this.btnExluir.UseVisualStyleBackColor = false;
            this.btnExluir.Click += new System.EventHandler(this.btnExluir_Click);
            // 
            // txtCodJogo
            // 
            this.txtCodJogo.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodJogo.Location = new System.Drawing.Point(301, 248);
            this.txtCodJogo.Name = "txtCodJogo";
            this.txtCodJogo.Size = new System.Drawing.Size(51, 34);
            this.txtCodJogo.TabIndex = 18;
            this.txtCodJogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodJogo_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.txtCodJogo);
            this.groupBox1.Controls.Add(this.lblRestricao);
            this.groupBox1.Controls.Add(this.btnExluir);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(51, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 457);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXCLUSÃO DE JOGOS";
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
            // frmExcluiJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExcluiJogo";
            this.Text = "Exclui jogo";
            ((System.ComponentModel.ISupportInitialize)(this.lblRestricao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView lblRestricao;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnExluir;
        private System.Windows.Forms.TextBox txtCodJogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}