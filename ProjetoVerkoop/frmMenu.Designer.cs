namespace ProjetoVerkoop
{
    partial class frmMenu
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
            this.btnPesqJogo = new System.Windows.Forms.Button();
            this.btnCadJogo = new System.Windows.Forms.Button();
            this.btnExcluirJogo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesqJogo
            // 
            this.btnPesqJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnPesqJogo.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.btnPesqJogo.ForeColor = System.Drawing.Color.White;
            this.btnPesqJogo.Location = new System.Drawing.Point(33, 120);
            this.btnPesqJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesqJogo.Name = "btnPesqJogo";
            this.btnPesqJogo.Size = new System.Drawing.Size(300, 63);
            this.btnPesqJogo.TabIndex = 9;
            this.btnPesqJogo.Text = "Pesquisar Jogo";
            this.btnPesqJogo.UseVisualStyleBackColor = false;
            this.btnPesqJogo.Click += new System.EventHandler(this.btnPesqJogo_Click);
            // 
            // btnCadJogo
            // 
            this.btnCadJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnCadJogo.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.btnCadJogo.ForeColor = System.Drawing.Color.White;
            this.btnCadJogo.Location = new System.Drawing.Point(33, 191);
            this.btnCadJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadJogo.Name = "btnCadJogo";
            this.btnCadJogo.Size = new System.Drawing.Size(300, 63);
            this.btnCadJogo.TabIndex = 11;
            this.btnCadJogo.Text = "Cadastrar Jogo";
            this.btnCadJogo.UseVisualStyleBackColor = false;
            this.btnCadJogo.Click += new System.EventHandler(this.btnCadJogo_Click);
            // 
            // btnExcluirJogo
            // 
            this.btnExcluirJogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnExcluirJogo.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.btnExcluirJogo.ForeColor = System.Drawing.Color.White;
            this.btnExcluirJogo.Location = new System.Drawing.Point(33, 262);
            this.btnExcluirJogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirJogo.Name = "btnExcluirJogo";
            this.btnExcluirJogo.Size = new System.Drawing.Size(300, 63);
            this.btnExcluirJogo.TabIndex = 12;
            this.btnExcluirJogo.Text = "Excluir jogo";
            this.btnExcluirJogo.UseVisualStyleBackColor = false;
            this.btnExcluirJogo.Click += new System.EventHandler(this.btnExcluirJogo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnSair.Location = new System.Drawing.Point(345, 549);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 39);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Controls.Add(this.btnExcluirJogo);
            this.groupBox1.Controls.Add(this.btnCadJogo);
            this.groupBox1.Controls.Add(this.btnPesqJogo);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 349);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "37 - Maria Clara Ramos Rocia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "22 - José Antonio Segura Marques da Silva\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "19 - Guilherme Martins Messa\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "18 - Guilherme Henrique Pinto Diorio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.lblNome.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 364);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(435, 34);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "11 - Davi Saito Gomes";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesqJogo;
        private System.Windows.Forms.Button btnCadJogo;
        private System.Windows.Forms.Button btnExcluirJogo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
    }
}