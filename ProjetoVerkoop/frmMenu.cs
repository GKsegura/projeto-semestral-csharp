using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVerkoop
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;

            frmSplash Splash = new frmSplash(this);
            Splash.ShowDialog();

            while (VariavelGlobal.logado == false)
            {
                if (VariavelGlobal.logar == 1)
                {
                    MessageBox.Show("Você deve fazer login para continuar!", "Verkoop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                VariavelGlobal.logar = 1;

                frmLogin Login = new frmLogin(this);
                Login.ShowDialog();
            }
            this.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo sair?", "Verkoop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }

        private void btnCadJogo_Click(object sender, EventArgs e)
        {
            frmCadJogo Jogo = new frmCadJogo();
            Jogo.ShowDialog();
            //this.Close();
        }

        private void btnPesqJogo_Click(object sender, EventArgs e)
        {
            frmPesqJogo Pesquisa = new frmPesqJogo();
            Pesquisa.ShowDialog();
            //this.Close();
        }

        private void btnExcluirJogo_Click(object sender, EventArgs e)
        {
            frmExcluiJogo ExcluirJogo = new frmExcluiJogo();
            ExcluirJogo.ShowDialog();
            //this.Close();
        }
    }
}
