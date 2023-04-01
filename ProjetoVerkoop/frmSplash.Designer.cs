namespace ProjetoVerkoop
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.picLogoSplash = new System.Windows.Forms.PictureBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoSplash
            // 
            this.picLogoSplash.Image = global::ProjetoVerkoop.Properties.Resources._7;
            this.picLogoSplash.ImageLocation = "";
            this.picLogoSplash.Location = new System.Drawing.Point(75, 167);
            this.picLogoSplash.Name = "picLogoSplash";
            this.picLogoSplash.Size = new System.Drawing.Size(314, 266);
            this.picLogoSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoSplash.TabIndex = 1;
            this.picLogoSplash.TabStop = false;
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 250;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 2000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.lblNome.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(17, 436);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(435, 34);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "11 - Davi Saito Gomes";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "18 - Guilherme Henrique Pinto Diorio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "19 - Guilherme Martins Messa\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "22 - José Antonio Segura Marques da Silva\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.label4.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "37 - Maria Clara Ramos Rocia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.picLogoSplash);
            this.Name = "frmSplash";
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoSplash;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}